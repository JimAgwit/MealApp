using MealApp.Models;

namespace MealApp.Services.Interface
{
    public interface IGetMealCategoryInterface
    {
        Task<CategoryList> GetMealCategorty();
    }
}
