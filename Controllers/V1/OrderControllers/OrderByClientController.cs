using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TechStore.Interfaces;
using TechStore.Models;

namespace TechStore.Controllers.V1.OrderControllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderByClientController : OrderController
    {
        public OrderByClientController(IOrderInterface orderInterface) : base(orderInterface)
        {
        }
        
        [HttpGet("client/{id}")]
        public async Task<ActionResult<IEnumerable<Order>>> GetOrdersByClientId(int id)
        {
            var orders = await _orderInterface.FilterOrderByClient(id);
            return Ok(orders);
        }
        
    }
}