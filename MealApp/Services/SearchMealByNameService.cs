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
        public async Task<MealSearchResponse> SearchMealByName(string mealName)
        {
            try
            {
                var urlExtension = "search.php?s=";
                var apiUrl = _configuration.GetValue<string>("MealDbUrl") + urlExtension + mealName;
                var response = await _httpClient.GetAsync(apiUrl);
                response.EnsureSuccessStatusCode();

                var content = await response.Content.ReadAsStringAsync();
                var meals = JsonConvert.DeserializeObject<MealSearchResponse>(content);
                return meals;
            }
            catch (Exception ex)
            {
                _logger.LogError("An error occured with the description: ", ex);
                throw;
            }

        }

    }
}
