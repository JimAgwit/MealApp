using MealApp.Models;

namespace MealApp.Services.Interface
{
    public interface IGetRandomMealInterface
    {
        Task<MealSearchResponse> GetRandomMeal();
    }
}
