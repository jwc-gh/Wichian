using Furion.DependencyInjection;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Wichian.Application
{
    public class SystemService : ISystemService, ITransient
    {
        public string GetDescription()
        {
            return "四零一八";
        }

        [HttpGet, NonUnify]
        public IActionResult FileDownload(string path, string fileName)
        {
            string filePath = Path.GetFullPath("~/temp/").Replace("~\\", "") + path;
            return new FileStreamResult(new FileStream(filePath, FileMode.Open), "application/octet-stream") { FileDownloadName = fileName };
        }

        [HttpPost, NonUnify]
        public async Task<IActionResult> UploadFileAsync(List<IFormFile> files)
        {
            long size = files.Sum(f => f.Length);

            foreach (var formFile in files)
            {
                if (formFile.Length > 0)
                {
                    var filePath = Path.GetTempFileName();  // 可以替代为你需要存储的真实路径

                    using (var stream = System.IO.File.Create(filePath))
                    {
                        await formFile.CopyToAsync(stream);
                    }
                }
            }

            return Ok(new { count = files.Count, size });
        }

        private IActionResult Ok(object p)
        {
            throw new System.NotImplementedException();
        }
    }
}