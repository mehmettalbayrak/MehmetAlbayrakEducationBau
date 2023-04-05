using System.Data.SqlClient;

namespace Proje03_VerilerinNesnelerleTasinmasi
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
            } while (secim!="0"); 
           
        }

        static void DisplayCustomers()
        {
            List<Customer> customers = GetAllCustomers();
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
            List<Product> products = GetAllProducts();
            Console.Clear();
            Console.WriteLine("ÜRÜN LİSTESİ");
            foreach (var product in products)
            {
                Console.WriteLine($"{product.Id}, {product.Name},{product.Price}, {product.Stock}");
            }
            Console.WriteLine("Ana menüye dönmek için entera basınız.");
            Console.ReadLine();
        }

        static List<Product> GetAllProducts() //verileri burada çekeceğiz. 
        {
            List<Product> products = new List<Product>(); //boş bir product listesi oluşturduk.
            using (var sqlConnection = GetSqlConnection())
            {
                try
                {
                    sqlConnection.Open();
                    string queryString = "SELECT p.ProductId, p.ProductName, p.UnitPrice, p.UnitsInStock FROM Products p";
                    SqlCommand sqlCommand = new SqlCommand(queryString, sqlConnection);
                    SqlDataReader reader = sqlCommand.ExecuteReader();
                    while (reader.Read()) //verilerin sırasıyla tek tek okunmasını sağlayacak ve false verene kadar da devam edecek. 
                    {
                        products.Add(new Product
                        {
                            Id = int.Parse(reader["ProductId"].ToString()), //parse sadece stringleri çevirir bu yüzden .tostring yazdık. Convert.ToInt32 yaparsak direkt objeleri çevirdiği için daha kısa olur.
                            Name = reader["ProductName"].ToString(),
                            Price = Convert.ToDecimal(reader["UnitPrice"]),
                            Stock = Convert.ToInt32(reader["UnitsInStock"])
                        });
                    }
                    reader.Close();
                }

                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    sqlConnection.Close();
                }
            }
            return products;
        }

        static List<Customer> GetAllCustomers()
        {
            List<Customer> customers = new List<Customer>(); //boş bir customer listesi
            using (var sqlConnection = GetSqlConnection())
            {
                try
                {
                    sqlConnection.Open();
                    string queryString = "SELECT c.CustomerID, c.CompanyName, c.City, c.Country FROM Customers c";
                    SqlCommand sqlCommand = new SqlCommand(queryString, sqlConnection);
                    SqlDataReader reader = sqlCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        customers.Add(new Customer
                        {
                            Id = (reader["CustomerID"]).ToString(),
                            Company = (reader["CompanyName"]).ToString(),
                            City = (reader["City"]).ToString(),
                            Country = (reader["Country"]).ToString()
                        });
                    }
                    reader.Close();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);

                }
                finally
                {
                    sqlConnection.Close();
                }
            }
            return customers;
        }

        static SqlConnection GetSqlConnection()
        {
            string connectionString = "Server=DESKTOP-E30TBPJ;Database=Northwind;User=sa;Password=123";
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }
    }
}