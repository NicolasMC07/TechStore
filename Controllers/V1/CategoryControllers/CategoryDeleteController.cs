using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TechStore.Interfaces;

namespace TechStore.Controllers.V1.CategoryControllers
{
    [ApiController]
    [Route("api/v1/delete")]
    public class CategoryDeleteController : CategoryController
    {
        public CategoryDeleteController(ICategoryInterface categoryInterface) : base(categoryInterface)
        {
           
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteCategory(int id)
        {
            await _categoryInterface.Delete(id);
            return NoContent(); 
        }
    }
}