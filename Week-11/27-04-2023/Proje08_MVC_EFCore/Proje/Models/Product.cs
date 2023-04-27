namespace Proje.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public string CreatedByName { get; set; }
        public decimal Price { get; set; }
        public Category Category { get; set; } /*Bu property'nin adı Navigation Property'dir. Örnek olarak; 8 Id'li ürün ve category ID'si 12 olan ürünü ilişkilendirmek için bunu yaptık.*/
    }
}
