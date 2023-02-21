namespace Proje17_Constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Ogrenci
            /*Ogrenci ogrenci1 = new Ogrenci("Halil");
            ogrenci1.Department = "Matematik";
            ogrenci1.Age = 25;

            Ogrenci ogrenci2 = new Ogrenci("Sezen")
            {
                Department = "Fizik",
                Age = 24
            };
            *//*Console.WriteLine($"ogrenci: {ogrenci1.Name}");
            Console.WriteLine($"ogrenci2: {ogrenci2.Name}");*//*

            Ogrenci ogrenci3 = new Ogrenci(); //boş constructor sayesinde parantez içine bir şey yazmadığımızda bize error vermedi.
            Console.WriteLine($"{ogrenci3.Name}, {ogrenci3.Department}, {ogrenci3.Age}");
            Ogrenci ogrenci4 = new Ogrenci("Kemal");
            Console.WriteLine($"{ogrenci4.Name}, {ogrenci4.Department}, {ogrenci4.Age}");
            Ogrenci ogrenci5 = new Ogrenci("Selma", "Fizik");
            Console.WriteLine($"{ogrenci5.Name}, {ogrenci5.Department}, {ogrenci5.Age}");
            Ogrenci ogrenci6 = new Ogrenci("Murat", "Bilgisayar", 19);
            Console.WriteLine($"{ogrenci6.Name}, {ogrenci6.Department}, {ogrenci6.Age}");*/
            #endregion

            Ayakkabi ayakkabi1 = new Ayakkabi()
            {
                Marka = "Adidas",
                Numara = 42,
                Cinsiyet = "Erkek",
                Durum = "Sağlam"
            };

            Ayakkabi ayakkabi2 = new Ayakkabi()
            {
            
            };

            Ayakkabi ayakkabi3 = new Ayakkabi(45);

            Console.WriteLine($"{ayakkabi1.Marka} - {ayakkabi1.Numara} - {ayakkabi1.Cinsiyet} - {ayakkabi1.Durum}");
        }
    }
}