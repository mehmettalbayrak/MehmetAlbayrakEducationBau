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
        public bool IsHome { get; set; } //Anasayfada g�stermek istedi�imiz �r�nler i�in olu�turdu�umuz property.
        public string Url { get; set; } //Url adresimizde �rnek olarak bir telefona bakacaksak localhost5265/GetProducts/5 yazmas�n https:/www.orneksite.com/iphone-13-k�rm�z�-128gb yazs�n diye. Bunu da SEO i�in yapmaktay�z.
        public string ImageUrl { get; set; } //Bu projemizde bir �r�n i�in �oklu foto�raf de�il tek foto�raf kullanaca��z. Bu foto�raflar� da depolamadan url adresinden �ekip alaca��z. Bu foto�raflar�n url'leri i�in olu�turdu�umuz property.
        public List<ProductCategory> ProductCategories { get; set; } //ProductCategory ile ili�ki kurmak i�in bu propertyi yazd�k.
    }

}
