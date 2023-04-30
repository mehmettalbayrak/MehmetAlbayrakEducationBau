namespace MiniShopApp.Entity.Concrete
{
    public class ProductCategory
    {
        public int ProductId { get; set; }
        public Product Product { get; set; } //Uygulamada kod yazarken bize kolaylık sağlayacak. yani product. yazdıktan sonra productcategory propertylerini kullanabileceğiz.
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }

}
