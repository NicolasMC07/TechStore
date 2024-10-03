using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TechStore.Models;

namespace TechStore.Seeders
{
    public class UserSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, Name = "admin", Password = "admin123", IdRole = 1 },
                new User { Id = 2, Name = "john_doe", Password = "password", IdRole = 2 },
                new User { Id = 3, Name = "guest_user", Password = "guest", IdRole = 3 }
            );
        }
    }
}