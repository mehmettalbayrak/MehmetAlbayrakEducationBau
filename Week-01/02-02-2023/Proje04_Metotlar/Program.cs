namespace Proje04_Metotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region MetinselMetotlar
            string metin = "Bahçeşehir Üniversitesi";
            int uzunluk = metin.Length; //Aslında Lenght bir metot değil.
            Console.WriteLine("\"" + metin + "\"" + " metninin uzunluğu " + uzunluk + " \\karakterdir.\\");
            Console.WriteLine($"{metin} metninin uzunluğu {uzunluk} karakterdir.");

            #endregion
        }
    }
}