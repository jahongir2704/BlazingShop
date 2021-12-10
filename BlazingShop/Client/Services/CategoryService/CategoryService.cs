using BlazingShop.Shared;

namespace BlazingShop.Client.Services.CategoryService
{
    public class CategoryService : ICategoryService
    {
        public List<Category> Categories { get; set; } = new List<Category>();

        public void LoadCategories()
        {
            Categories = new List<Category>
            {
                new Category{Id = 1, Name = "Video Games", Url = "video-games", Icon = "aperture"},
                new Category{Id = 2, Name ="Electronics",  Url = "electronics", Icon = "camera-slr"},
                new Category{Id = 3, Name ="Movies",       Url = "movies",      Icon = "book"}
            };
        }
    }
}
