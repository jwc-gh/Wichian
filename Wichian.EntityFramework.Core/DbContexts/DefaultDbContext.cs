using Furion.DatabaseAccessor;
using Microsoft.EntityFrameworkCore;

namespace Wichian.EntityFramework.Core
{
    [AppDbContext("Wichian", DbProvider.Sqlite)]
    public class DefaultDbContext : AppDbContext<DefaultDbContext>
    {
        public DefaultDbContext(DbContextOptions<DefaultDbContext> options) : base(options)
        {
        }
    }
}