using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechStore.Data;
using TechStore.Interfaces;
using TechStore.Models;

namespace TechStore.Services
{
    public class CategoryServices : ICategoryInterface
    {
        private readonly AppDbContext _Context;

        public CategoryServices(AppDbContext _context)
        {
            _Context = _context;
        }

        Task<IEnumerable<Category>> GetAll()
        {

        }
        Task Create(Category category)
        {

        }

        Task Update(Category category)
        {

        }

        Task Delete(int id)
        {
            
        }
    }
}