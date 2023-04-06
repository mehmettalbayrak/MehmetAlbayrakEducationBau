using Proje.DAL.Concrete;
using Proje.Entities;
using System.Data.SqlClient;

namespace Proje
{
    public class Program
    {
        static void Main(string[] args)
        {
            //müşteri company name girince o müşteriye ait satışlar listelensin.
            string secim;
            do
            {
                Console.WriteLine("Northwind Veri Tabanı");
                Console.WriteLine("1-Ürün Listesi");
                Console.WriteLine("2-Müşteri Listesi");
                Console.WriteLine("3-ID'ye Göre Ürün Arama");
                Console.WriteLine("4-ID'ye Göre Müşteri Arama");
                Console.WriteLine("5-Categorye Göre Ürün Listesi");
                Console.WriteLine("6-Şirket Adına Göre Satış Listesi");
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
                else if (secim == "4")
                {
                    GetCustomerById();
                }
                else if (secim == "5")
                {
                    GetProductsByCategory();
                }
                else if (secim == "6")
                {
                    GetSalesByCompanyName();
                }
            } while (secim != "0");

        }

        static void GetSalesByCompanyName()
        {
            Console.Clear();
            Console.WriteLine("Şirket İsmine Göre Satışlar");
            Console.Write("Şirket İsmini Giriniz: ");
            string companyName = Console.ReadLine();
            OrderDAL orderDAL = new OrderDAL();
            List<Order> orders = orderDAL.GetSalesByCompanyName(companyName);
            Console.Clear();
            Console.WriteLine($"{companyName} müşterisinin satışları");
            foreach (var order in orders)
            {
                Console.WriteLine($"{order.Id}, {order.OrderDate},{order.Country}");
            }
            Console.WriteLine("Ana menüye dönmek için enter'a basınız.");
            Console.ReadLine();

        }

        static void GetProductsByCategory()
        {
            Console.Clear();
            Console.WriteLine("Kategoriye Göre Ürün Listesi");
            Console.Write("Kategori adını giriniz: ");
            string categoryName = Console.ReadLine();
            ProductDAL productDAL = new ProductDAL();
            List<Product> products = productDAL.GetProductsByCategory(categoryName);
            Console.Clear();
            Console.WriteLine($"{categoryName} KATEGORİSİNDEKİ ÜRÜN LİSTESİ");
            foreach (var product in products)
            {
                Console.WriteLine($"{product.Id}, {product.Name}, {product.Price}, {product.Stock}, {product.CategoryName}");
            }
            Console.Write("Ana menüye dönmek için enter'a basınız...");
            Console.ReadLine();
        }

        static void GetProductById()
        {
            Console.Clear();
            Console.WriteLine("ID'ye Göre Ürün Arama");
            Console.Write("Ürün ID'sini Giriniz: ");
            string id = (Console.ReadLine());
            ProductDAL productDAL = new ProductDAL();
            Product product = productDAL.GetById(id);
            Console.WriteLine("Sonuç: ");
            if (product == null)
            {
                Console.WriteLine("Aradığınız ürün bulunamadı.");
            }
            else
            {
                Console.WriteLine($"{product.Id},{product.Name},{product.Price},{product.Stock}");
                Console.ReadLine();
            }
            Console.WriteLine("Ana menüye dönmek için enter'a basınız.");
        }

        static void GetCustomerById()
        {
            Console.Clear();
            Console.WriteLine("ID'ye Göre Müşteri Arama");
            Console.Write("Müşteri ID'sini Giriniz: ");
            string id = Console.ReadLine();
            CustomerDAL customerDAL = new CustomerDAL();
            Customer customer = customerDAL.GetById(id);
            Console.WriteLine("Sonuç: ");
            if (customer == null)
            {
                Console.WriteLine("Aradığınız ürün bulunamadı.");
            }
            else
            {
                Console.WriteLine($"{customer.Id},{customer.Country},{customer.City},{customer.Company}");
                Console.ReadLine();
            }
            Console.WriteLine("Ana menüye dönmek için enter'a basınız.");
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


