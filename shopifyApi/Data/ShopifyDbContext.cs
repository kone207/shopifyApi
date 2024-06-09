using Microsoft.EntityFrameworkCore;
using shopifyApi.Models;

namespace shopifyApi.Data
{
    public class ShopifyDbContext : DbContext
    {
        public ShopifyDbContext(DbContextOptions<ShopifyDbContext> options)
            :base(options)
        {

        }

        public DbSet<Item> Items { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Item>().Property(x => x.Price).HasColumnType("decimal(18.2)");
        }
    }
}
