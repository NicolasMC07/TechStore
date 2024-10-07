using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TechStore.DTOs;
using TechStore.Interfaces;

namespace TechStore.Controllers.V1.OrderControllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderUpdateController : OrderController
    {
        public OrderUpdateController(IOrderInterface orderInterface) : base(orderInterface)
        {
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, OrderDTO order)
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
            var existOrder = await _orderInterface.GetById(id);
            if (existOrder == null)
            {
                return NotFound(); // Retorna 404 si la categoría no existe
            }

            // Actualiza las propiedades de la categoría existente
            existOrder.Status = order.Status;
            existOrder.DateOrder = order.DateOrder;
            existOrder.QuantityProduct = order.QuantityProduct;
            existOrder.IdClient = order.IdClient;


            // Realiza la actualización en la base de datos
            await _orderInterface.UpdateOrder(existOrder);

            return NoContent(); // Retorna 204 No Content al finalizar correctamente
        }
    }
}