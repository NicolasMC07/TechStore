using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TechStore.Models;
using TechStore.Seeders;

namespace TechStore.Data
{
    public class AppDbContext : DbContext
    {   
        public DbSet<Order> Orders { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductOrder> ProductOrders { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        public AppDbContext (DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            RoleSeeder.Seed(modelBuilder);
            CategorySeeder.Seed(modelBuilder);
            ClientSeeder.Seed(modelBuilder);
            OrderSeeder.Seed(modelBuilder);
            ProductSeeder.Seed(modelBuilder);
            ProductOrderSeeder.Seed(modelBuilder); 
            UserSeeder.Seed(modelBuilder);

            // Configure the many-to-many relationship for ProductOrder
            modelBuilder.Entity<ProductOrder>()
                .HasKey(op => op.Id); // Composite primary key

            modelBuilder.Entity<ProductOrder>()
                .HasOne(css => css.Product) // Relationship to Product
                .WithMany(c => c.ProductOrders)
                .HasForeignKey(css => css.IdProduct)
                .OnDelete(DeleteBehavior.Cascade); // Cascade delete

            modelBuilder.Entity<ProductOrder>()
                .HasOne(css => css.Order) // Relationship to Order
                .WithMany(ss => ss.ProductOrders)
                .HasForeignKey(css => css.IdOrder)
                .OnDelete(DeleteBehavior.Restrict); // Restrict delete
        }
    }
}
