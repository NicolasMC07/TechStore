using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TechStore.DTOs;
using TechStore.Interfaces;

namespace TechStore.Controllers.V1.ProductControllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductUpdateController : ProductController
    {
        public ProductUpdateController(IProductInterface productInterface) : base(productInterface)
        {
        }
        
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateClient(int id, PrductDTO product)
        {
            // if (!ModelState.IsValid)
            // {
            //     return BadRequest(ModelState);
            // }
            // var checkVehicle = await _vehicleRepository.CheckExistence(id);
            // if (checkVehicle == false)
            // {
            //     return NotFound();
            // }    

            var productId = await _productInterface.FilterProductById(id);

            if (product == null)
            {
                return NotFound();
            }

            product.Name = product.Name;
            product.Price = product.Price;
            product.Description = product.Description;
            product.Quantity = product.Quantity;
            product.IdCategory = product.IdCategory;


            await _productInterface.UpdateProduct(productId);
            return NoContent();
        }
    }
}