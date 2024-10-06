using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechStore.Models;

namespace TechStore.Interfaces
{
    public interface IOrderInterface
    {
        Task<Order?> GetById(int id);

        Task CreateOrder(Order order);
        Task UpdateOrder(Order order);

        Task DeleteOrder(int id);
        Task<IEnumerable<Order>> FilterOrderByClient(int id);
        Task<IEnumerable<Order>> FilterOrderByStatus(string status);
        Task<IEnumerable<Order>> FilterOrderByCreationDate(DateTime dateTime);
    }
}