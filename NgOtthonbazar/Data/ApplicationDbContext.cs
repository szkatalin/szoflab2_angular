using Microsoft.EntityFrameworkCore;
using Otthonbazar.Data.EntityTypeConfigurations;

namespace Otthonbazar.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Advertisement> Advertisements { get; set; }
        public DbSet<City> Cities { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Advertisement>()
                .HasOne(a => a.City)
                .WithMany(c => c.Advertisements)
                .HasForeignKey(a => a.CityId);

            builder.ApplyConfiguration(new CitySeedConfig());
            builder.ApplyConfiguration(new AdvertisementSeedConfig());
        }
    }
}
