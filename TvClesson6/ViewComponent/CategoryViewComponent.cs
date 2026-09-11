using Microsoft.AspNetCore.Mvc;
using TvClesson6.Models;

namespace TvClesson6.ViewComponents
{
    public class CategoryViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(int? n)
        {
            var categories = new List<Category>
            {
                new Category { categoryId = 1, categoryName = "Electronics", IsActive = true },
                new Category { categoryId = 2, categoryName = "Books", IsActive = true },
                new Category { categoryId = 3, categoryName = "Clothing", IsActive = false },
                new Category { categoryId = 4, categoryName = "Home & Kitchen", IsActive = true }
            };
            n = n ?? 0;
            var search =categories.Where(c => c.categoryId>n).ToList();
            return View(search);
        }
    }
}
