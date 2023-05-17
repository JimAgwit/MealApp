using MealApp.Models;
using MealApp.Services.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;

namespace MealApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
      private readonly IMealServiceInterface _mealService;
        public CategoryController(IMealServiceInterface mealService)
        {
            _mealService = mealService;
        }
        [HttpGet]
        public async Task<IActionResult> GetMealCategories()
        {
            var category= await _mealService.GetMealCategorty();
            return Ok(category);

        }
    }
}
