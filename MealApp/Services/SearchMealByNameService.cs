using MealApp.Models;
using MealApp.Services.Interface;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System.Net.Http;

namespace MealApp.Services
{
    public class SearchMealByNameService : ISearchMealByNameInterface
    {
        private readonly ILogger<GetMealCategoryService> _logger;
        private readonly HttpClient _httpClient;
        private readonly IConfiguration _configuration;

        public SearchMealByNameService(HttpClient httpClient, ILogger<GetMealCategoryService> logger, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _logger = logger;
            _configuration = configuration;
        }
        public Task<Meal> SearchMealByName()
        {
            using (HttpClient client = new HttpClient())
            {
                string apiUrl = "https://www.themealdb.com/api/json/v1/1/search.php?s=Arrabiata";
                string json = await client.GetStringAsync(apiUrl);

                // Deserialize the JSON response
                MealSearchResponse response = JsonConvert.DeserializeObject<MealSearchResponse>(json);

                // Access the search results
                List<Meal> meals = response.Meals;

                // Do something with the meals
            }
        }
    }
}
