using Blog.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Blog.Controllers
{
    [ApiController]
    public class CategoryController : ControllerBase
    {
        //localhost:PORT/v1/categories
        [HttpGet("v1/categories")] //Lowercase with - if you have more than one word like CategoryRole == category-role
        public async Task<IActionResult> GetAsync(
            [FromServices] BlogDataContext context
        )
        {
            var categories = await context.Categories.ToListAsync();
            return Ok(categories);
        }
    }
}