using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TechStore.Models;

namespace TechStore.Seeders
{
    public class OrderSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>().HasData(
                new Order { Id = 1, Status = "Pendiente", DateOrder = DateTime.Now, QuantityProduct = 2, IdClient = 1 },
                new Order { Id = 2, Status = "Completado", DateOrder = DateTime.Now.AddDays(-1), QuantityProduct = 1, IdClient = 2 },
                new Order { Id = 3, Status = "Cancelado", DateOrder = DateTime.Now.AddDays(-2), QuantityProduct = 3, IdClient = 3 }
            );
        }
    }
}