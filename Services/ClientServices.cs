using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TechStore.Data;
using TechStore.Interfaces;
using TechStore.Models;

namespace TechStore.Services
{
    public class ClientServices : IClientInterface
    {
        protected readonly AppDbContext _Context;

        public ClientServices(AppDbContext _context)
        {
            _Context = _context;
        }

        public async Task Add(Client client)
        {
            if (client == null)
            {
                throw new ArgumentNullException(nameof(client), "el cliente no uede ser nula.");
            }

            try
            {
                await _Context.Clients.AddAsync(client);
                await _Context.SaveChangesAsync();
            }
            catch (DbUpdateException dbEx)
            {
                throw new Exception("Error al agregar el cliente a la base de datos.", dbEx);
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrió un error inesperado al agregar el cliente.", ex);
            }
        }

        public async Task<IEnumerable<Client>> GetAll()
        {
            return await _Context.Clients.ToListAsync();
        }

        public async Task Update(Client client)
        {
            if (client == null)
            {
                throw new ArgumentNullException(nameof(client), "El cliente no puede ser nulo.");
            }

            try
            {
                _Context.Entry(client).State = EntityState.Modified;
                await _Context.SaveChangesAsync();
            }
            catch (DbUpdateException dbEx)
            {
                throw new Exception("Error al actualizar  el cliente en la base de datos.", dbEx);
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrió un error inesperado al actualizar el cliente.", ex);
            }
        }
        public async Task<Client> GetById(int id)
        {
            return await _Context.Clients.FindAsync(id);
        }
    }
}