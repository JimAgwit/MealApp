namespace MealApp.Models
{
    public class Category
    {
        public int idCategory { get; set; }
        public string strCategory { get; set; } 
        public string strCategoryThumb { get; set; }
        public string strCategoryDescription { get; set; }
    }
    public class CategoryList
    {
        public List<Category> Categories { get; set; }
    }
}
