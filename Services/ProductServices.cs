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
    public class ProductServices : IProductInterface
    {
        private readonly AppDbContext _Context;

        public ProductServices(AppDbContext _context)
        {
            _Context = _context;
        }

        public async Task CreateProduct(Product product)
        {
            if (product == null)
            {
                throw new ArgumentNullException(nameof(product), "La categoria no uede ser nula.");
            }

            try
            {
                await _Context.Products.AddAsync(product);
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

        public async Task DeleteProduct(int id)
        {
            var product = await _Context.Categories.FindAsync(id);
            if (product != null)
            {
                _Context.Categories.Remove(product);
                await _Context.SaveChangesAsync();
            }
        }

        public async Task<Product> FilterProductById(int id)
        {
            return await _Context.Products.FindAsync(id);
        }

        public async Task<IEnumerable<Product>> GetProducts()
        {
            return await _Context.Products.ToListAsync();
        }

        public async Task UpdateProduct(Product product)
        {
            if (product == null)
            {
                throw new ArgumentNullException(nameof(product), "La categoria no puede ser nulo.");
            }

            try
            {
                _Context.Entry(product).State = EntityState.Modified;
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
    }
}