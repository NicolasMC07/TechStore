using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TechStore.DTOs;
using TechStore.Interfaces;

namespace TechStore.Controllers.V1.ClientControllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClientUpdateController : ClientController
    {
        public ClientUpdateController(IClientInterface clientInterface) : base(clientInterface)
        {
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateClient(int id, ClientDTO client)
        {
            // if (!ModelState.IsValid)
            // {
            //     return BadRequest(ModelState);
            // }
            // var checkVehicle = await _vehicleRepository.CheckExistence(id);
            // if (checkVehicle == false)
            // {
            //     return NotFound();
            // }    

            var clientId = await _clientInterface.GetById(id);

            if (client == null)
            {
                return NotFound();
            }

            client.Name = client.Name;
            client.Address = client.Address;
            client.PhoneNumber = client.PhoneNumber;
            client.Email = client.Email;

            await _clientInterface.Update(clientId);
            return NoContent();
        }
    }
}