using MealApp.Models;
using MealApp.Services.Interface;
using System.Net.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace MealApp.Services
{
    public class GetMealCategoryService : IMealServiceInterface
    {
        private readonly ILogger<GetMealCategoryService> _logger;
        private readonly HttpClient _httpClient;
        private readonly IConfiguration _configuration;
       

        public GetMealCategoryService(HttpClient httpClient, ILogger<GetMealCategoryService> logger, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _logger = logger;
            _configuration = configuration;

        }

        public async Task<CategoryList> GetMealCategorty()
        {
            

            try
            {
                var apiUrl = _configuration.GetValue<string>("MealDbUrl");
                var response = await _httpClient.GetAsync(apiUrl);
                response.EnsureSuccessStatusCode();

                var content = await response.Content.ReadAsStringAsync();
                var categories = JsonConvert.DeserializeObject<CategoryList>(content);
                return categories;
            }
            catch (Exception ex)
            {
                _logger.LogError("An error occured with the description: ", ex);
                throw;
            }
        
        }

     
    }
}
