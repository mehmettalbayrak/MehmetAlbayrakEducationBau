using Microsoft.AspNetCore.Mvc;
using Proje.Models;
using Proje.ViewModels;

namespace Proje.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            Repository repository = new Repository();
            List<Product> products = repository.InitProducts();
            List<Category> categories = repository.InitCategories();
            ViewBag.Kategoriler = categories;
            return View(products);
        }
        public IActionResult ProductDetails()
        {
            Repository repository = new Repository();
            List<Product> products = repository.InitProducts();
            List<ProductCategory> productCategoryList = new List<ProductCategory>();
            foreach (var product in products)
            {
                productCategoryList.Add(new ProductCategory
                {
                    Product = product
                });

            }
            List<Category> categories = repository.InitCategories();
            productCategoryList[0].Category = categories[1];
            productCategoryList[1].Category = categories[0];
            productCategoryList[2].Category = categories[2];
            productCategoryList[3].Category = categories[1];
            productCategoryList[4].Category = categories[0];
            return View(productCategoryList);
        }
    }
}
