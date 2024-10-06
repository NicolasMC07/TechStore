using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TechStore.DTOs;
using TechStore.Interfaces;
using TechStore.Models;

namespace TechStore.Controllers.V1.ClientControllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClientCreateController : ClientController
    {
        public ClientCreateController(IClientInterface clientInterface) : base(clientInterface)
        {
        }

        [HttpPost]
        public async Task<IActionResult> CreateCategory(ClientDTO clientDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);  
            }

            var newClient = new Client(clientDTO.Name, clientDTO.Address, clientDTO.PhoneNumber, clientDTO.Email);

            await _clientInterface.Add(newClient);

            return Ok(newClient);
        }
    }
}