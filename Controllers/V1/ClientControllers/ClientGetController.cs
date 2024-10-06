using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TechStore.Interfaces;
using TechStore.Models;

namespace TechStore.Controllers.V1.ClientControllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClientGetController : ClientController
    {
        public ClientGetController(IClientInterface clientInterface) : base(clientInterface)
        {
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Client>>> GetAll()
        {
            var client = await _clientInterface.GetAll();
            return Ok(client);
        }
    }
}