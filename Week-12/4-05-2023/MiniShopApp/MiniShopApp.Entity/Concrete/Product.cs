using MiniShopApp.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShopApp.Entity.Concrete
{
    public class Product:BaseEntity
    {
        public string Name { get; set; }
        public string Properties { get; set; }
        public decimal Price { get; set; }
        public bool IsHome { get; set; } //Anasayfada göstermek istediðimiz ürünler için oluþturduðumuz property.
        public string Url { get; set; } //Url adresimizde örnek olarak bir telefona bakacaksak localhost5265/GetProducts/5 yazmasýn https:/www.orneksite.com/iphone-13-kýrmýzý-128gb yazsýn diye. Bunu da SEO için yapmaktayýz.
        public string ImageUrl { get; set; } //Bu projemizde bir ürün için çoklu fotoðraf deðil tek fotoðraf kullanacaðýz. Bu fotoðraflarý da depolamadan url adresinden çekip alacaðýz. Bu fotoðraflarýn url'leri için oluþturduðumuz property.
        public List<ProductCategory> ProductCategories { get; set; } //ProductCategory ile iliþki kurmak için bu propertyi yazdýk.
    }

}
