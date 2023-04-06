using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proje.DAL.Abstract;
using Proje.Entities;

namespace Proje.DAL.Concrete
{
    public class ProductDAL : IProductDAL
    {
        public List<Product> GetProductsByCategory(string categoryName)
        {
            List<Product> products = new List<Product>();
            using (var sqlConnection = SqlConnections.GetSqlConnection())
            {
                try
                {
                    sqlConnection.Open();
                    string queryString = $"SELECT p.ProductID, p.ProductName, p.UnitPrice, p.UnitsInStock, c.CategoryName FROM Products p INNER JOIN Categories c ON p.CategoryID=c.CategoryID WHERE c.CategoryName='{categoryName}'";
                    SqlCommand sqlCommand = new SqlCommand(queryString, sqlConnection);
                    SqlDataReader reader = sqlCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        products.Add(new Product
                        {
                            Id = Convert.ToInt32(reader["ProductID"]),
                            Name = reader["ProductName"].ToString(),
                            Price = Convert.ToDecimal(reader["UnitPrice"]),
                            Stock = Convert.ToInt32(reader["UnitsInStock"]),
                            CategoryName = reader["CategoryName"].ToString()
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

        public void Create()
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Product GetById(string id)
        {
            Product product = null; //boş bir product nesnesi. 1 tane.
            using (var sqlConnection = SqlConnections.GetSqlConnection())
            {
                try
                {
                    sqlConnection.Open();
                    string queryString = $"SELECT p.ProductId, p.ProductName, p.UnitPrice, p.UnitsInStock FROM Products p WHERE p.ProductID={id}";
                    SqlCommand sqlCommand = new SqlCommand(queryString, sqlConnection);
                    SqlDataReader reader = sqlCommand.ExecuteReader();
                    if (reader.Read()) //verilerin sırasıyla tek tek okunmasını sağlayacak ve false verene kadar da devam edecek. 
                    {
                        product = new Product
                        {
                            Id = int.Parse(reader["ProductId"].ToString()), //parse sadece stringleri çevirir bu yüzden .tostring yazdık. Convert.ToInt32 yaparsak direkt objeleri çevirdiği için daha kısa olur.
                            Name = reader["ProductName"].ToString(),
                            Price = Convert.ToDecimal(reader["UnitPrice"]),
                            Stock = Convert.ToInt32(reader["UnitsInStock"])
                        };
                    }
                    //Alternatif
                    /* while (reader.Read()) //verilerin sırasıyla tek tek okunmasını sağlayacak ve false verene kadar da devam edecek. 
                     {
                         product = new Product
                         {
                             Id = int.Parse(reader["ProductId"].ToString()), //parse sadece stringleri çevirir bu yüzden .tostring yazdık. Convert.ToInt32 yaparsak direkt objeleri çevirdiği için daha kısa olur.
                             Name = reader["ProductName"].ToString(),
                             Price = Convert.ToDecimal(reader["UnitPrice"]),
                             Stock = Convert.ToInt32(reader["UnitsInStock"])
                         };
                     }*/
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
            return product;
        }

        public void Update(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll() //verileri burada çekeceğiz. 
        {
            List<Product> products = new List<Product>(); //boş bir product listesi oluşturduk.
            using (var sqlConnection = SqlConnections.GetSqlConnection())
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
    }
}
