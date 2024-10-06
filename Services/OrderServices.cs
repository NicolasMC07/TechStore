using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
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

        public async Task CreateOrder(Order order)
        {
            if (order == null)
            {
                throw new ArgumentNullException(nameof(order), "La categoria no uede ser nula.");
            }

            try
            {
                await _Context.Orders.AddAsync(order);
                await _Context.SaveChangesAsync();
            }
            catch (DbUpdateException dbEx)
            {
                throw new Exception("Error al agregar la categoria a la base de datos.", dbEx);
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrió un error inesperado al agregar la categoria.", ex);
            }
        }

        public async Task DeleteOrder(int id)
        {
            var order = await _Context.Orders.FindAsync(id);
            if (order != null)
            {
                _Context.Orders.Remove(order);
                await _Context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Order>> FilterOrderByClient(int id)
        {
            return await _Context.Orders.Where(o => o.IdClient == id).ToListAsync();
        }

        public async Task<IEnumerable<Order>> FilterOrderByStatus(string status)
        {
            return await _Context.Orders.Where(o => o.Status == status).ToListAsync();
        }

        public async Task<IEnumerable<Order>> FilterOrderByCreationDate(DateTime dateTime)
        {
            return await _Context.Orders.Where(o => o.DateOrder.Date == dateTime.Date).ToListAsync();
        }

        public async Task UpdateOrder(Order order)
        {
            if (order == null)
            {
                throw new ArgumentNullException(nameof(order), "La categoria no puede ser nulo.");
            }

            try
            {
                _Context.Entry(order).State = EntityState.Modified;
                await _Context.SaveChangesAsync();
            }
            catch (DbUpdateException dbEx)
            {
                throw new Exception("Error al actualizar  la categoria en la base de datos.", dbEx);
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrió un error inesperado al actualizar la categoria.", ex);
            }
        }

        public async Task<Order> GetById(int id)
        {
            return await _Context.Orders.FindAsync(id);
        }
    }
}