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
    public class OrderByStatusController : OrderController
    {
        public OrderByStatusController(IOrderInterface orderInterface) : base(orderInterface)
        {
        }

        [HttpGet("status/{status}")]
        public async Task<ActionResult<IEnumerable<Order>>> GetOrdersByStatus(string status)
        {
            var orders = await _orderInterface.FilterOrderByStatus(status);
            return Ok(orders);
        }
    }
}