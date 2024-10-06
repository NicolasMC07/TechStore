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
    public class OrderController : ControllerBase
    {
        protected readonly IOrderInterface _orderInterface;

        public OrderController(IOrderInterface orderInterface)
        {
            _orderInterface = orderInterface;
        }
    }
}