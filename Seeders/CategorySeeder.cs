using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TechStore.Models;

namespace TechStore.Seeders
{
    public class CategorySeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Laptops", Description = "Una variedad de laptops para diferentes necesidades." },
                new Category { Id = 2, Name = "Smartphones", Description = "Los últimos smartphones del mercado." },
                new Category { Id = 3, Name = "Accesorios", Description = "Accesorios para mejorar tu experiencia tecnológica." }
            );
        }
    }
}