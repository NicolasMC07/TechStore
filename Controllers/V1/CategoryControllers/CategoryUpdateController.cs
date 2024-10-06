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

            var categoryId = await _categoryInterface.GetById(id);

            if (category == null)
            {
                return NotFound();
            }

            category.Name = category.Name;
            category.Description = category.Description;

            await _categoryInterface.Update(categoryId);
            return NoContent();
        }
    }
}