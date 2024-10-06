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
    public class ProductGetController : ProductController
    {
        public ProductGetController(IProductInterface productInterface) : base(productInterface)
        {
        }

        public async Task<ActionResult<IEnumerable<Product>>> GetAll()
        {
            var product = await _productInterface.GetProducts();
            return Ok(product);
        }
    }
}