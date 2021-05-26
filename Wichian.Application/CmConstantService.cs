using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Furion.DynamicApiController;
using Furion.DatabaseAccessor;
using Wichian.Core.EMIS.CM;
using Yitter.IdGenerator;
using Microsoft.AspNetCore.Mvc;

namespace Wichian.Core
{
    public class CmConstantService : IDynamicApiController, ICmConstantService
    {
        private List<Constant> constantlist = new List<Constant>();

        /// <summary>
        /// 新增
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public void AddItem(string code, string name, string group)
        {
            var constant = new Constant
            {
                Id = 1,
                Code = code,
                Name = name,
                Group = group,
                CreateId = 0,
                ModifyId = 0,
                CreateTime = DateTime.UtcNow,
                ModifyTime = DateTime.UtcNow,
                IsDeleted = false
            };

            constantlist.Add(constant);
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <returns></returns>
        [HttpDelete]
        public void DeleteItem(string code)
        {
            
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <returns></returns>
        [HttpPut]
        public void UpdateItem(string code, string name, string group)
        {
            
        }
        /// <summary>
        /// 获取
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public Constant GetItem(int id)
        {
            return new Constant();
        }
        /// <summary>
        /// 获取集合
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<Constant> GetSet(string group)
        {
            
            return constantlist;
        }

        [HttpGet]
        public long GetId()
        {
            return YitIdHelper.NextId();
        }
    }
}
