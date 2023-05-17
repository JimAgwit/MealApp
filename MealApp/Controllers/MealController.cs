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
        private readonly IGetRandomMealInterface _randomMeal;
        public MealController(ISearchMealByNameInterface searchByMealName, IGetRandomMealInterface randomMeal)
        {
            _searchByMealName = searchByMealName;
            _randomMeal = randomMeal;
        }

        [HttpGet("searchMealByName")]
        public async Task<IActionResult> SearchMealByName(string mealName)
        {
            var meals = await _searchByMealName.SearchMealByName(mealName);
            return Ok(meals);
        }
        [HttpGet("getRandomMeal")]
        public async Task<IActionResult> GetRandomMeal()
        {
            var meals = await _randomMeal.GetRandomMeal();
            return Ok(meals);
        }
    }
}
