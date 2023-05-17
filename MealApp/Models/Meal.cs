using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MealApp.Models
{
    public class MealSearchResponse
    {
        public List<Meal> Meals { get; set; }
    }

    public class Meal
    {
        public string IdMeal { get; set; }
        public string StrMeal { get; set; }
        public string StrDrinkAlternate { get; set; }
        public string StrCategory { get; set; }
        public string StrArea { get; set; }
        public string StrInstructions { get; set; }
        public string StrMealThumb { get; set; }
        public string StrTags { get; set; }
        public string StrYoutube { get; set; }
        public string StrSource { get; set; }
        public string StrImageSource { get; set; }
        public string StrCreativeCommonsConfirmed { get; set; }
        public string DateModified { get; set; }
    }
}
