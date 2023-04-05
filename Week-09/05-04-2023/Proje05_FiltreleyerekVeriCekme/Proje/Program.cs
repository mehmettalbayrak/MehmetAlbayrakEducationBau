using Proje.DAL;
using Proje.Entities;
using System.Data.SqlClient;

namespace Proje
{
    public class Program
    {
        static void Main(string[] args)
        {
            string secim;
            do
            {
                Console.WriteLine("Northwind Veri Tabanı");
                Console.WriteLine("1-Ürün Listesi");
                Console.WriteLine("2-Müşteri Listesi");
                Console.WriteLine("3-ID'ye Göre Ürün Arama");
                Console.WriteLine("0-Çıkış");
                Console.Write("Seçiminizi yapınız: ");
                secim = Console.ReadLine();
                if (secim == "1")
                {
                    DisplayProducts();
                }
                else if (secim == "2")
                {
                    DisplayCustomers();
                }
                else if (secim == "3")
                {
                    GetProductById();
                }
            } while (secim != "0");

        }

        static void GetProductById()
        {
            Console.Clear();
            Console.WriteLine("ID'ye Göre Ürün Arama");
            Console.Write("Ürün ID'sini Giriniz: ");
            int id = int.Parse(Console.ReadLine());
            //PAUSE Gidip ProductDAL içindeki GetById metodunu dolduralım sonra buraya geri dönelim.
        }

        static void DisplayCustomers()
        {
            CustomerDAL customerDAL = new CustomerDAL();
            List<Customer> customers = customerDAL.GetAll();
            Console.Clear();
            Console.WriteLine("MÜŞTERİ LİSTESİ");
            foreach (var customer in customers)
            {
                Console.WriteLine($"{customer.Id},{customer.Company},{customer.City},{customer.Country}");
            }
            Console.WriteLine("Ana menüye dönmek için entera basınız.");
            Console.ReadLine();
        }

        static void DisplayProducts()
        {
            //İlk işimiz productları veri tabanından çekmek ama bu işi burada yapmayacağız. Başka bir metodda yapıp o metodu buraya çağıracağız.
            ProductDAL productDAL = new ProductDAL();
            List<Product> products = productDAL.GetAll();
            Console.Clear();
            Console.WriteLine("ÜRÜN LİSTESİ");
            foreach (var product in products)
            {
                Console.WriteLine($"{product.Id}, {product.Name},{product.Price}, {product.Stock}");
            }
            Console.WriteLine("Ana menüye dönmek için entera basınız.");
            Console.ReadLine();
        }

    }
}


