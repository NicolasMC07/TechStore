using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TechStore.DTOs;
using TechStore.Interfaces;

namespace TechStore.Controllers.V1.CategoryControllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoryUpdateController : CategoryController
    {
        public CategoryUpdateController(ICategoryInterface categoryInterface) : base(categoryInterface)
        {
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, CategoryDTO category)
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
            var existingCategory = await _categoryInterface.GetById(id);
            if (existingCategory == null)
            {
                return NotFound(); // Retorna 404 si la categoría no existe
            }

            // Actualiza las propiedades de la categoría existente
            existingCategory.Name = category.Name;
            existingCategory.Description = category.Description;

            // Realiza la actualización en la base de datos
            await _categoryInterface.Update(existingCategory);

            return NoContent(); // Retorna 204 No Content al finalizar correctamente
        }
    }
}