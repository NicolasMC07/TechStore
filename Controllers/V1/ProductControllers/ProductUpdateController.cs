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
        public async Task<IActionResult> Update(int id, PrductDTO product)
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

            // Verifica si el modelo es válido
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // Verifica si la categoría existe
            var existProduct = await _productInterface.FilterProductById(id);
            if (existProduct == null)
            {
                return NotFound(); // Retorna 404 si la categoría no existe
            }

            // Actualiza las propiedades de la categoría existente
            existProduct.Name = product.Name;
            existProduct.Price = product.Price;
            existProduct.Description = product.Description;
            existProduct.IdCategory = product.IdCategory;


            // Realiza la actualización en la base de datos
            await _productInterface.UpdateProduct(existProduct);

            return NoContent(); // Retorna 204 No Content al finalizar correctamente
        }
    }
}