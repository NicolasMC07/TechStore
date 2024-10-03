using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechStore.Models;

namespace TechStore.Interfaces
{
    public interface ICategoryInterface
    {
        Task<IEnumerable<Category>> GetAll();
        Task Create(Category category);

        Task Update(Category category);

        Task Delete(int id);

    }
}

