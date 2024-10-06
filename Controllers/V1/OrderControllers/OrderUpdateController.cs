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
        public async Task<IActionResult> UpdateClient(int id, OrderDTO order)
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

            var orderId = await _orderInterface.GetById(id);

            if (order == null)
            {
                return NotFound();
            }

            order.Status = order.Status;
            order.DateOrder = order.DateOrder;
            order.QuantityProduct = order.QuantityProduct;
            order.IdClient = order.IdClient;

            await _orderInterface.UpdateOrder(orderId);
            return NoContent();
        }
    }
}