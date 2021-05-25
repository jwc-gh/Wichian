using Furion.DatabaseAccessor;
using Microsoft.EntityFrameworkCore;

namespace Wichian.EntityFramework.Core
{
    [AppDbContext("ARMConnectionString", DbProvider.Sqlite)]
    public class ARMDbContext : AppDbContext<ARMDbContext, ARMDbContextLocator>
    {
        public ARMDbContext(DbContextOptions<ARMDbContext> options) : base(options)
        {
        }
    }
}
