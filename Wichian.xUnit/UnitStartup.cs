using System;
using Xunit;
using Xunit.Sdk;
using Xunit.Abstractions;
using Furion;
using Microsoft.Extensions.DependencyInjection;

[assembly:TestFramework("Wichian.xUnit.UnitStartup", "Wichian.xUnit")]
namespace Wichian.xUnit
{
    public class UnitStartup : XunitTestFramework
    {
        public UnitStartup(IMessageSink messageSink) : base(messageSink)
        {
            var services = Inject.Create();
            services.Build();
        }
    }
}
