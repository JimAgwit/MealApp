using MealApp.Models;

namespace MealApp.Services.Interface
{
    public interface ISearchMealByNameInterface
    {
        Task<MealSearchResponse> SearchMealByName(string mealName);
    }
}
