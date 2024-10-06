using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TechStore.Interfaces;
using TechStore.Models;

namespace TechStore.Controllers.V1.ProductControllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductByIdController : ProductController
    {
        public ProductByIdController(IProductInterface productInterface) : base(productInterface)
        {
        }
        
        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProductById(int id)
        {
            var product = await _productInterface.FilterProductById(id);
            return Ok(product);
        }
    }
}