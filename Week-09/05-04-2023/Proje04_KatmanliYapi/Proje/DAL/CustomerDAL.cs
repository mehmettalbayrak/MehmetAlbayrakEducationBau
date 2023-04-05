using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proje.Entities;

namespace Proje.DAL
{
    public class CustomerDAL: IGenericDAL<Customer>
    {
        public void Create()
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Customer GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(int id)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetAll()
        {
            List<Customer> customers = new List<Customer>(); //boş bir customer listesi
            using (var sqlConnection = SqlConnections.GetSqlConnection())
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
    }
}
