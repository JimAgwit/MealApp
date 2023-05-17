using MealApp.Models;

namespace MealApp.Services.Interface
{
    public interface ISearchMealByNameInterface
    {
        Task<Meal> SearchMealByName();
    }
}
