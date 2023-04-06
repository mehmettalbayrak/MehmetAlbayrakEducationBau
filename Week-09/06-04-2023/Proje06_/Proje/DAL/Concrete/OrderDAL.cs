using Proje.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Proje.DAL.Abstract;

namespace Proje.DAL.Concrete
{
    public class OrderDAL : IOrderDAL
    {

        public List<Order> GetSalesByCompanyName(string companyName)
        {
            List<Order> orders = new List<Order>(); //boş bir product listesi oluşturduk.
            using (var sqlConnection = SqlConnections.GetSqlConnection())
            {
                try
                {
                    sqlConnection.Open();
                    string queryString = $"select o.OrderID, o.OrderDate, o.ShipCountry from Orders o right join Customers c on o.CustomerID=c.CustomerID where c.CompanyName= '{companyName}'";
                    SqlCommand sqlCommand = new SqlCommand(queryString, sqlConnection);
                    SqlDataReader reader = sqlCommand.ExecuteReader();
                    while (reader.Read()) //verilerin sırasıyla tek tek okunmasını sağlayacak ve false verene kadar da devam edecek. 
                    {
                        orders.Add(new Order
                        {
                            Id = int.Parse(reader[0].ToString()), //parse sadece stringleri çevirir bu yüzden .tostring yazdık. Convert.ToInt32 yaparsak direkt objeleri çevirdiği için daha kısa olur.
                            OrderDate = (DateTime)reader[1],
                            Country = reader[2].ToString(),
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
            return orders;
        }
        public void Create()
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Order> GetAll()
        {
            throw new NotImplementedException();
        }

        public Order GetById(string id)
        {
            throw new NotImplementedException();
        }

        public void Update(int id)
        {
            throw new NotImplementedException();
        }
    }
}
