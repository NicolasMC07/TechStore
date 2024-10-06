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
    public class OrderByCreationDateController : OrderController
    {
        public OrderByCreationDateController(IOrderInterface orderInterface) : base(orderInterface)
        {
        }

        [HttpGet("date/{dateTime}")]
        public async Task<ActionResult<IEnumerable<Order>>> GetOrdersByCreationDate(DateTime dateTime)
        {
            var orders = await _orderInterface.FilterOrderByCreationDate(dateTime);
            return Ok(orders);
        }
    }
}