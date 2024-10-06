using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TechStore.Interfaces;

namespace TechStore.Controllers.V1.ProductControllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductDeleteController : ProductController
    {
        public ProductDeleteController(IProductInterface productInterface) : base(productInterface)
        {
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            await _productInterface.DeleteProduct(id);
            return NoContent(); 
        }
    }
}