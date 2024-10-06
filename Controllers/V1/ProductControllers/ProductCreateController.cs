using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TechStore.DTOs;
using TechStore.Interfaces;
using TechStore.Models;

namespace TechStore.Controllers.V1.ProductControllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductCreateController : ProductController
    {
        public ProductCreateController(IProductInterface productInterface) : base(productInterface)
        {
        }

        [HttpPost]
        public async Task<IActionResult> CreateProduct(PrductDTO prductDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);  
            }

            var newProduct = new Product(prductDTO.Name, prductDTO.Price, prductDTO.Description, prductDTO.Quantity, prductDTO.IdCategory);

            await _productInterface.CreateProduct(newProduct);

            return Ok(newProduct);
        }
    }
}