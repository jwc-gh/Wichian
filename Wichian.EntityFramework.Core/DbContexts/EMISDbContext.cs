using Furion.DatabaseAccessor;
using Microsoft.EntityFrameworkCore;

namespace Wichian.EntityFramework.Core
{
    [AppDbContext("EMISConnectionString", DbProvider.Sqlite)]
    public class EMISDbContext : AppDbContext<EMISDbContext, EMISDbContextLocator>
    {
        public EMISDbContext(DbContextOptions<EMISDbContext> options) : base(options)
        {
        }
    }
}
