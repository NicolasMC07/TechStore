using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TechStore.Interfaces;
using TechStore.Models;

namespace TechStore.Controllers.V1.CategoryControllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoryGetController : CategoryController
    {
        public CategoryGetController(ICategoryInterface categoryInterface) : base(categoryInterface)
        {
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Category>>> GetAll()
        {
            var category = await _categoryInterface.GetAll();
            return Ok(category);
        }
    }
}