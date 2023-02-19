namespace Proje16_OOP_Uygulama1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcının gireceği n adet Product bilgisinin nesnelerede tutularak, listelenmesini sağlayalım.

            Console.Write("Kaç adet Product bilgisi vereceksiniz?: ");
            int adet = Convert.ToInt32(Console.ReadLine());

            Product[] products = new Product[adet];
            Product product;
            for (int i = 0; i < products.Length; i++)
            {
                product = new Product();
                product.Id = i + 1; 
                Console.Write("Product Name?: ");
                product.Name = Console.ReadLine();
                Console.Write("Product Price?: ");
                product.Price = Convert.ToDouble(Console.ReadLine());
                Console.Write("Product Description: ");
                product.Description = Console.ReadLine();

                products[i] = product;
            }
            foreach (Product p in products)
            {
                Console.WriteLine($"Id: {p.Id} - Name: {p.Name} - Price: {p.Price} - Description: {p.Description}");
            }
        }
    }
}