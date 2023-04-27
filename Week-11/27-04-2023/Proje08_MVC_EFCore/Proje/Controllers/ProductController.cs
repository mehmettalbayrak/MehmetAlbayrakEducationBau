using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Proje.Models;

namespace Proje.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            using (var _context = new ProjeAppContext())
            {
                List<Product> products = _context.Products.Include(p=>p.Category).ToList();
                //Aşağıdaki View metodu, Views/Product/Index.cshtml dosyasını(Viewini) çalıştırır. Ve bu metod çalışırken ilgili cshtml dosyasına products nesnesini (model) gönderir.
                return View(products);
            }
        }

        public IActionResult GetProductDetails(int id) /*program.cs'deki route tanımlamasındaki isim ne ise buradaki isim de o olacak.(default'u id)*/
        {
            using (var _context = new ProjeAppContext())
            {
                Product product = _context.Products.Where(p=>p.Id == id).Include(p => p.Category).FirstOrDefault();
                /*Product products = _context.Products.Include(p=> p.Category).FirstOrDefault();*/
                return View(product);
            }
            
        }
    }
}