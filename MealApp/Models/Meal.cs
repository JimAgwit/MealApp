using Newtonsoft.Json;

namespace MealApp.Models
{
    public class MealSearchResponse
    {
        public List<Meal> Meals { get; set; }
    }

    public class Meal
    {
        [JsonProperty("idMeal")]
        public string Id { get; set; }

        [JsonProperty("strMeal")]
        public string Name { get; set; }

        [JsonProperty("strCategory")]
        public string Category { get; set; }

        [JsonProperty("strArea")]
        public string Area { get; set; }

        [JsonProperty("strInstructions")]
        public string Instructions { get; set; }

        [JsonProperty("strMealThumb")]
        public string ThumbnailUrl { get; set; }

        [JsonProperty("strTags")]
        public string Tags { get; set; }

        [JsonProperty("strYoutube")]
        public string YoutubeUrl { get; set; }

        [JsonProperty("strSource")]
        public string Source { get; set; }

        [JsonProperty("strImageSource")]
        public string ImageSource { get; set; }

        [JsonProperty("strCreativeCommonsConfirmed")]
        public string CreativeCommonsConfirmed { get; set; }

        [JsonProperty("dateModified")]
        public string DateModified { get; set; }

        public List<string> Ingredients { get; set; }
        public List<string> Measures { get; set; }
    }
}
