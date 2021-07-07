using FindHome.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FindHome.Data
{
    public class FindHomeDbContext : IdentityDbContext<IdentityUser>
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
                optionsBuilder.UseSqlServer("Server=DESKTOP-11LDN42\\SQLEXPRESS;Database=FindHome;Integrated Security=true;");
            }
        }

        public DbSet<Address> Addresses { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Message> Messages { get; set; }
        
        public DbSet<Property> Properties { get; set; }
        public DbSet<ZipCode> ZipCodes { get; set; }
        public DbSet<UserMessage> UserMessages { get; set; }
        public DbSet<UserFavoriteProperty> UserFavoriteProperties { get; set; }
        


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<UserFavoriteProperty>()
                .HasKey(x => new { x.PropertyId, x.UserId });

            modelBuilder.Entity<UserMessage>()
                .HasKey(x => new { x.UserId, x.MessageId});
        }
    }
}
