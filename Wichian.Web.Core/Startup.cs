using Furion;
using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Yitter.IdGenerator;

namespace Wichian.Web.Core
{
    public class Startup : AppStartup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews()
                        .AddInject();
            services.AddRemoteRequest(options =>{
                options.AddHttpClient("baidu_pan", c =>
                {
                    c.BaseAddress = new Uri("https://pan.baidu.com/");
                    c.DefaultRequestHeaders.Add("Accept", "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,image/apng,*/*;q=0.8,application/signed-exchange;v=b3;q=0.9");
                });
            });
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }
            
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseInject(string.Empty);

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });

            //设置雪花ID配置，确保每个示例的workerid不同
            YitIdHelper.SetIdGenerator(new IdGeneratorOptions()
            {
                WorkerIdBitLength = byte.Parse(App.Configuration["SnowId:WorkerIdBitLength"] ?? "6"),
                WorkerId = ushort.Parse(App.Configuration["SnowId:WorkerId"] ?? "1"),
                SeqBitLength = byte.Parse(App.Configuration["SnowId:SeqBitLength"] ?? "6"),
                MinSeqNumber = ushort.Parse(App.Configuration["SnowId:MinSeqNumber"] ?? "5"),
                MaxSeqNumber = ushort.Parse(App.Configuration["SnowId:MaxSeqNumber"] ?? "0"),
                Method = short.Parse(App.Configuration["SnowId:Method"] ?? "1"),
                BaseTime = DateTime.Parse(App.Configuration["SnowId:BaseTime"] ?? "2000-02-20 02:20:02.20").ToUniversalTime(),
                TopOverCostCount = int.Parse(App.Configuration["SnowId:TopOverCostCount"] ?? "2000")
            });
        }
    }
}