using MealApp.Services.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MealApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MealController : ControllerBase
    {
        private readonly ISearchMealByNameInterface _searchByMealName;
        public MealController(ISearchMealByNameInterface searchByMealName)
        {
            _searchByMealName = searchByMealName;
        }

        [HttpGet("searchMealByName")]
        public async Task<IActionResult> SearchMealByName(string mealName)
        {
            var meals = await _searchByMealName.SearchMealByName(mealName);
            return Ok(meals);
        }
    }
}
