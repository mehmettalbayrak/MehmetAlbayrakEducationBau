using System.Data.SqlClient;

namespace Proje02_VerilerinCekilmesi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlConnection connection = GetSqlConnection();
            try
            {
                connection.Open();
                //veri tabanı ile ilgili işlerimizi yapacağız.
                string queryString = "SELECT * FROM Products";
                SqlCommand command = new SqlCommand(queryString, connection);
                SqlDataReader reader = command.ExecuteReader();
                int siraNo = 1;
                while (reader.Read())
                {
                    Console.WriteLine(siraNo + "-" + reader[1] + "-" + reader[5]);
                    siraNo++;
                }
                reader.Close();

            }
            catch (Exception)
            {
                Console.WriteLine("Bir hata oluştu admin ile iletişime geçiniz.");
            }
            finally
            {
                connection.Close();
            }
        }
        static SqlConnection GetSqlConnection()
        {
            string connectionString = "Server=DESKTOP-E30TBPJ;Database=Northwind;User=sa;Password=123;";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            return sqlConnection;
        }
    }
}