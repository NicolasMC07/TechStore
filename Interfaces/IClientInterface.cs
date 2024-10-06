using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechStore.Models;

namespace TechStore.Interfaces
{
    public interface IClientInterface
    {   
        Task<Client?> GetById(int id);
        Task<IEnumerable<Client>> GetAll();
        Task Add (Client client);
        Task Update (Client client);
    }
}