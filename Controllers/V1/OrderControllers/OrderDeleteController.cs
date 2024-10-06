using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TechStore.Interfaces;

namespace TechStore.Controllers.V1.OrderControllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderDeleteController : OrderController
    {
        public OrderDeleteController(IOrderInterface orderInterface) : base(orderInterface)
        {
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteOrder(int id)
        {
            await _orderInterface.DeleteOrder(id);
            return NoContent(); 
        }
    }
}