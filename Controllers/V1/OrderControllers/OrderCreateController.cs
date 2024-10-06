using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TechStore.DTOs;
using TechStore.Interfaces;
using TechStore.Models;

namespace TechStore.Controllers.V1.OrderControllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderCreateController : OrderController
    {
        public OrderCreateController(IOrderInterface orderInterface) : base(orderInterface)
        {
        }

        [HttpPost]
        public async Task<IActionResult> CreateOrder(OrderDTO orderDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);  
            }

            var newOrder = new Order(orderDTO.Status, orderDTO.DateOrder, orderDTO.QuantityProduct, orderDTO.IdClient);

            await _orderInterface.CreateOrder(newOrder);

            return Ok(newOrder);
        }
    }
}