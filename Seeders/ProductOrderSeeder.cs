using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TechStore.Models;

namespace TechStore.Seeders
{
    public class ProductOrderSeeder
    {
         public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductOrder>().HasData(
                new ProductOrder { Id = 1, IdProduct = 1, IdOrder = 1 },
                new ProductOrder { Id = 2, IdProduct = 2, IdOrder = 1 },
                new ProductOrder { Id = 3, IdProduct = 1, IdOrder = 2 },
                new ProductOrder { Id = 4, IdProduct = 3, IdOrder = 3 }
            );
        }
    }
}