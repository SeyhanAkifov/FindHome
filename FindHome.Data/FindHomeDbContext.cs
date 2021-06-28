using Microsoft.EntityFrameworkCore;

namespace FindHome.Data
{
    public class FindHomeDbContext : DbContext
    {
        public FindHomeDbContext()
        {

        }
        public FindHomeDbContext(DbContextOptions<FindHomeDbContext> options)
            : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("ConnectionString");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
