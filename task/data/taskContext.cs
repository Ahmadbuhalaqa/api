using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace task.data
{
    public class taskContext:DbContext
    {

        IConfiguration config;
        public taskContext(IConfiguration _config)
        {
            config = _config;
        }

        public DbSet<Country> countries { get; set; }

        public DbSet<City> cities { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(config.GetConnectionString("task95"));
            base.OnConfiguring(optionsBuilder);
        }
    }
}
