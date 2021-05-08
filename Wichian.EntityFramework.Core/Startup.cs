using Furion;
using Microsoft.Extensions.DependencyInjection;

namespace Wichian.EntityFramework.Core
{
    public class Startup : AppStartup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDatabaseAccessor(options =>
            {
                options.AddDbPool<DefaultDbContext>();
            }, "Wichian.Database.Migrations");
        }
    }
}