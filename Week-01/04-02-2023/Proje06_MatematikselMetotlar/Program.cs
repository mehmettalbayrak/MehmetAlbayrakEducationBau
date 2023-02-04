namespace Proje06_MatematikselMetotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 40;
            int sayi2 = 50;
            Console.WriteLine("Min: " + Math.Min(sayi1, sayi2));
            Console.WriteLine("Max: " + Math.Max(sayi1, sayi2));

            Console.Clear();
            int sayi = 4;
            int us = 2;
            int sonuc =Convert.ToInt32(Math.Pow(sayi, us)); //pow üs alırken kullanacağımız komut.
            Console.WriteLine(sonuc);

            Console.Clear();
            /*Kullanıcıdan taban ve üs kuvvetini alıp, tabanın üssüncü kuvvetini hesaplayarak ekrana yazdıran kodu yazalım.*/

            /*Console.Write("Üssünü alacağınız sayıyı giriniz: ");
            int tabanSayi = int.Parse(Console.ReadLine());
            Console.Write("Üssü giriniz: ");
            int usSayi = int.Parse(Console.ReadLine());
            double result = Math.Pow(tabanSayi, usSayi); //sistem double'a dönüştürdüğü için double kullandık. Uyarı verince double olması gerektiğini gösterdi. Decimal gibi düşünebiliriz double'ı. Ondalık sayılar için kullanılır.
            Console.WriteLine($"{tabanSayi} sayısının {usSayi}. kuvveti = {result}");*/

            Console.Clear();
            Console.WriteLine(Math.Round(110.8)); //round ondalık sayıları yuvarlamak için kullanılır.

        }
    }
}