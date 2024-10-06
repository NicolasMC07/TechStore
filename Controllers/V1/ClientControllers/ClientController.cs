using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TechStore.Interfaces;

namespace TechStore.Controllers.V1.ClientControllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClientController : ControllerBase
    {
        protected readonly IClientInterface _clientInterface;
        
        public ClientController(IClientInterface clientInterface)
        {
            _clientInterface = clientInterface;
        }
    }
}