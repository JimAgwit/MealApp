using MealApp.Models;
using MealApp.Services.Interface;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System.Net.Http;

namespace MealApp.Services
{
    public class GetRandomMealService : IGetRandomMealInterface
    {
        private readonly ILogger<GetMealCategoryService> _logger;
        private readonly HttpClient _httpClient;
        private readonly IConfiguration _configuration;
        public GetRandomMealService(HttpClient httpClient, ILogger<GetMealCategoryService> logger, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _logger = logger;
            _configuration = configuration;
        }
        public async Task<MealSearchResponse> GetRandomMeal()
        {
            try
            {
                var urlExtension = "random.php";
                var apiUrl = _configuration.GetValue<string>("MealDbUrl") + urlExtension;
                var response = await _httpClient.GetAsync(apiUrl);
                response.EnsureSuccessStatusCode();

                var content = await response.Content.ReadAsStringAsync();
                var randomMeal = JsonConvert.DeserializeObject<MealSearchResponse>(content);
                return randomMeal;
            }
            catch (Exception ex)
            {
                _logger.LogError("An error occured with the description: ", ex);
                throw;
            }
        }
    }
}
