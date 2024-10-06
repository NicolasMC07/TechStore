using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TechStore.DTOs;
using TechStore.Interfaces;
using TechStore.Models;

namespace TechStore.Controllers.V1.CategoryControllers
{
    [ApiController]
    [Route("api/v1/category")]
    public class CategoryCreateController : CategoryController
    {
        public CategoryCreateController(ICategoryInterface categoryInterface) : base(categoryInterface)
        {
        }

        [HttpPost]
        public async Task<IActionResult> CreateCategory(CategoryDTO categoryDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var newCategory = new Category(categoryDTO.Name, categoryDTO.Description);

            await _categoryInterface.Create(newCategory);

            return Ok(newCategory);
        }
    }
}
