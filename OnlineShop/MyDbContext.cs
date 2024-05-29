using Microsoft.EntityFrameworkCore;
using OnlineShop.Models;

namespace OnlineShop
{
    public class MyDbContext : DbContext
    {
        private string _connectionString = "Server=(localdb)\\mssqllocaldb;Database=OnlineShopDb;Trusted_Connection=True;";
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; } 
        public DbSet<Order> Orders { get; set; }  
        public DbSet<OrderedItem> OrderedItems { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<OrderedItem>()
               .Property(o => o.UnitPrice)
               .HasColumnType("decimal(18,2)");
            modelBuilder.Entity<Product>()
               .Property(o => o.Price)
               .HasColumnType("decimal(18,2)");
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }
    }
}
