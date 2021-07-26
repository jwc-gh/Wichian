using Furion;
using Furion.DependencyInjection;
using Furion.RemoteRequest.Extensions;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Wichian.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var services = Inject.Create();
            services.AddRemoteRequest();
            services.Build();

            var helloservice = App.GetService<IHelloService>();
            Console.WriteLine(helloservice.SayHello());

            var baiducontent = "https://www.baidu.com".GetAsStringAsync().GetAwaiter().GetResult();
            Console.WriteLine(baiducontent);
        }
    }

    public interface IHelloService
    {
        string SayHello();
    }

    public class HelloService : IHelloService, ITransient
    {
        public string SayHello()
        {
            return "Hello Wichian";
        }
    }
}
