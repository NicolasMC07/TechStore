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
    public class CategoryServices : ICategoryInterface
    {
        protected readonly AppDbContext _Context;

        public CategoryServices(AppDbContext _context)
        {
            _Context = _context;
        }

        public async Task<IEnumerable<Category>> GetAll()
        {
            return await _Context.Categories.ToListAsync();
        }
        public async Task Create(Category category)
        {
            if (category == null)
            {
                throw new ArgumentNullException(nameof(category), "La categoria no uede ser nula.");
            }

            try
            {
                await _Context.Categories.AddAsync(category);
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

        public async Task Update(Category category)
        {
            if (category == null)
            {
                throw new ArgumentNullException(nameof(category), "La categoria no puede ser nulo.");
            }

            try
            {
                _Context.Entry(category).State = EntityState.Modified;
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

        public async Task Delete(int id)
        {
            var category = await _Context.Categories.FindAsync(id);
            if (category != null)
            {
                _Context.Categories.Remove(category);
                await _Context.SaveChangesAsync();
            }
        }

        public async Task<Category> GetById(int id)
        {
            return await _Context.Categories.FindAsync(id);
        }
    }
}