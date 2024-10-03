using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TechStore.Models;

namespace TechStore.Seeders
{
    public class ClientSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>().HasData(
                new Client { Id = 1, Name = "Juan Pérez", Address = "Calle Falsa 123", PhoneNumber = "123-456-7890", Email = "juan.perez@example.com" },
                new Client { Id = 2, Name = "María López", Address = "Avenida Siempre Viva 742", PhoneNumber = "987-654-3210", Email = "maria.lopez@example.com" },
                new Client { Id = 3, Name = "Carlos García", Address = "Paseo del Río 456", PhoneNumber = "555-123-4567", Email = "carlos.garcia@example.com" }
            );
        }
    }
}