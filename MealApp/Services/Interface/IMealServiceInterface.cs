using MealApp.Models;

namespace MealApp.Services.Interface
{
    public interface IMealServiceInterface
    {
        Task<CategoryList> GetMealCategorty();
    }
}
