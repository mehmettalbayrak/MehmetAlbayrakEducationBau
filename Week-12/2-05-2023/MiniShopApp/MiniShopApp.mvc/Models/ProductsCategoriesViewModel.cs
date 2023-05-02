using MiniShopApp.Entity.Concrete;

namespace MiniShopApp.mvc.Models
{
    public class ProductsCategoriesViewModel
    {
        public List<Product> Products { get; set; }
        public List<Category> Categories { get; set; }
    }
}
