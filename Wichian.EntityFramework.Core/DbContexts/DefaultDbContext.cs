using Furion.DatabaseAccessor;
using Microsoft.EntityFrameworkCore;

namespace Wichian.EntityFramework.Core
{
    [AppDbContext("Data Source=./Wichian.db", DbProvider.Sqlite)]
    public class DefaultDbContext : AppDbContext<DefaultDbContext>
    {
        public DefaultDbContext(DbContextOptions<DefaultDbContext> options) : base(options)
        {
        }
    }
}