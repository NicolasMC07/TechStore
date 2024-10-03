using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechStore.Models;

namespace TechStore.Interfaces
{
    public interface IProductInterface
    {
        Task<IEnumerable<Product>> GetProducts ();
        Task<Product> FilterProductById(int id);
        Task CreateProduct (Product product);
        Task UpdateProduct (Product product);
        Task DeleteProduct (int id);
    }
}