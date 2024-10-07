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
        public async Task<IActionResult> Update(int id, ClientDTO client)
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

            // Verifica si el modelo es válido
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // Verifica si la categoría existe
            var existClient = await _clientInterface.GetById(id);
            if (existClient == null)
            {
                return NotFound(); // Retorna 404 si la categoría no existe
            }

            // Actualiza las propiedades de la categoría existente
            existClient.Name = client.Name;
            existClient.Address = client.Address;
            existClient.PhoneNumber = client.PhoneNumber;
            existClient.Email = client.Email;


            // Realiza la actualización en la base de datos
            await _clientInterface.Update(existClient);

            return NoContent(); // Retorna 204 No Content al finalizar correctamente
        }
    }
}