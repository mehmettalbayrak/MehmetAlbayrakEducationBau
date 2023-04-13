namespace Proje.Models
{
    public class Repository
    {
        public List<Product> InitProducts()
        {
            return new List<Product>
            {
                new Product { Id = 1, Name="iPhone 13", Description="Yeni 4K çekim özelliği."},
                new Product { Id = 2, Name="iPhone 13 Pro Max", Description="Yeni 4K çekim özelliği daha geniş ekranda!"},
                new Product { Id = 3, Name="iPhone 14", Description="Yeni 4K ve HDR çekim özelliği."},
                new Product { Id = 4, Name="iPhone 14 Pro Max", Description="Yeni 4K ve HDR çekim özelliği daha geniş ekran deneyiminde."},
                new Product { Id = 5, Name="iPhone 8 Plus", Description="Şıklık ve sadelik bir arada."}
            };
        }
        public List<Category> InitCategories()
        {
            return new List<Category>
            {
                new Category { Id = 1, Name="Bilgisayar"},
                new Category { Id = 2, Name="Telefon"},
                new Category { Id = 3, Name="Beyaz Eşya"}
            };
        }
    }
}
