using Microsoft.EntityFrameworkCore;
using RETAIL_STORE_BACKEND.Models;

namespace RETAIL_STORE_BACKEND.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
                
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductColours>()
                .HasKey(x => new { x.ProductId, x.ColourId });

            modelBuilder.Entity<ProductColours>()
               .HasOne(y => y.Product)
               .WithMany(c => c.ProCol)
               .HasForeignKey(y => y.ProductId);

            modelBuilder.Entity<ProductColours>()
                .HasOne(y => y.Colour)
                .WithMany(c => c.ProCol)
                .HasForeignKey(y => y.ColourId);


            modelBuilder.Entity<ProductPowers>()
    .HasKey(x => new { x.ProductId, x.PowerId });

            modelBuilder.Entity<ProductPowers>()
               .HasOne(y => y.Product)
               .WithMany(c => c.ProPow)
               .HasForeignKey(y => y.ProductId);

            modelBuilder.Entity<ProductPowers>()
                .HasOne(y => y.Power)
                .WithMany(c => c.ProPow)
                .HasForeignKey(y => y.PowerId);

        }

        public DbSet<Colour> Colours { get; set; }

        public DbSet<Power> Powers { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<ProductColours> ProductColouts { get; set; }

        public DbSet<ProductPowers> ProductPowers { get; set; }
    }
}
