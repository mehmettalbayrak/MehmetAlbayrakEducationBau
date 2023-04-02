using System.Data.SqlClient;

namespace Proje01_SQLBaglantiOlusturma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Connection String
            string connectionString = "Server = DESKTOP-E30TBPJ;Database=Northwind;User Id=sa;Password=123";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            try
            {
                sqlConnection.Open();
                Console.WriteLine("Bağlantı açıldı..");
                Console.WriteLine("Bu aşamada veri tabanı ile ilgili işlemler yapılır..");
                Console.WriteLine("Bağlantıyı kapatmak için ENTER'a basın.");
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally {
                sqlConnection.Close();
                Console.WriteLine("Bağlantı kapatıldı..");
            }
 
        }
    }
}
//İlk hali
/*SqlConnection sqlConnection = new SqlConnection(connectionString);
sqlConnection.Open();
Console.WriteLine("Veri tabanı bağlantısı açıldı.");
Console.WriteLine("Veri tabanını kapatmak için entera basın.");
Console.ReadLine();
sqlConnection.Close();
Console.WriteLine("Veri tabanı bağlantısı sonlandırıldı.");*/