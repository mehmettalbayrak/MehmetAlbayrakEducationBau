using Microsoft.AspNetCore.Mvc;

namespace Proje.Controllers
{
    //

    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(); //Eğer View metoduna bir parametre verilmezse (boş bırakılırsa) bu metod projenin Views klasörü altındaki ilgili Controller adıyla bulunan klasörün içindeki yine ilgili Action adındaki .cshtml dosyasını arar. 
            //Yani Views/Home/index.cshtml dosyasını arar.
        }
        public IActionResult About() 
        {
            return View();
        }
        public IActionResult Contact() 
        {
            return View();
        }
    }
}
