using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MiniShopApp.Entity.Concrete;

namespace MiniShopApp.mvc.Models
{
    public class ProductViewModel
    {
        public int id { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string Name { get; set; }
        public string Properties { get; set; }
        public decimal Price { get; set; }
        public string Url { get; set; } //Url adresimizde �rnek olarak bir telefona bakacaksak localhost5265/GetProducts/5 yazmas�n https:/www.orneksite.com/iphone-13-k�rm�z�-128gb yazs�n diye. Bunu da SEO i�in yapmaktay�z.
        public string ImageUrl {get; set;}
        public List<Category> CategoryList { get; set; }
    }
}