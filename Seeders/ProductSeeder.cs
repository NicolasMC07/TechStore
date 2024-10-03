using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TechStore.Models;

namespace TechStore.Seeders
{
    public class ProductSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, Name = "Laptop XYZ", Price = 999.99, Description = "Laptop potente para juegos y trabajo.", Quantity = 10, IdCategory = 1 },
                new Product { Id = 2, Name = "Smartphone ABC", Price = 599.99, Description = "Smartphone con cámara de alta calidad.", Quantity = 20, IdCategory = 2 },
                new Product { Id = 3, Name = "Auriculares Bluetooth", Price = 89.99, Description = "Auriculares inalámbricos con cancelación de ruido.", Quantity = 50, IdCategory = 3 }
            );
        }
    }
}