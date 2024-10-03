using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechStore.Models;

namespace TechStore.Interfaces
{
    public interface IOrderInterface
    {
        Task CreateOrder (Order order);
        Task UpdateOrder (Order order);

        Task DeleteOrder (int id);
        Task FilterOrderByClient(string client);
        Task FilterOrderByStatus(string status);

        Task FilterOrderByCreationDate(DateTime dateTime);





    }
}