namespace Proje07_TarihselMetotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Today);
            DateTime dogumTarihi = new DateTime(1995, 10, 30);
            Console.WriteLine(dogumTarihi);
            TimeSpan span = DateTime.Now.Subtract(dogumTarihi); //TimeSpan: Zaman aralığını bize veriyor.Subtract: çıkarma işlemi.
            Console.WriteLine(Math.Round(span.TotalDays));

            Console.Clear();
            DateTime bugun = DateTime.Now;
            Console.WriteLine(bugun);
            Console.WriteLine(bugun.ToShortDateString());
            Console.WriteLine(bugun.ToLongDateString());
            Console.WriteLine(bugun.ToShortTimeString());
            Console.WriteLine(bugun.ToLongTimeString());

            Console.Clear();
            int yil = bugun.Year + 1;
            int ay = 1;
            int gun = 1;
            DateTime gelecekYilinIlkGunu = new DateTime(yil, ay, gun);
            Console.WriteLine(gelecekYilinIlkGunu.ToLongDateString());
        }
    }
}