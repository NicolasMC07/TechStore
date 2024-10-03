using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http.HttpResults;
using TechStore.Data;
using TechStore.Interfaces;
using TechStore.Models;

namespace TechStore.Services
{
    public class OrderServices : IOrderInterface
    {
        private readonly AppDbContext _Context;

        public OrderServices(AppDbContext _context)
        {
            _Context = _context;
        }

        Task CreateOrder (Order order)
        {
            
        }
        Task UpdateOrder (Order order)
        {

        }

        Task DeleteOrder (int id)
        {

        }
        Task FilterOrderByClient(string client)
        {

        }
        Task FilterOrderByStatus(string status)
        {

        }

        Task FilterOrderByCreationDate(DateTime dateTime)
        {
            
        }
    }
}