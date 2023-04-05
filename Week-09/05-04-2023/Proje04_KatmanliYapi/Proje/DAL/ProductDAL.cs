using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proje.Entities;

namespace Proje.DAL
{
    public class ProductDAL: IGenericDAL<Product>
    {
        public void Create()
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Product GetById(int id)
        {
            throw new NotImplementedException();
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
