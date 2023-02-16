namespace Proje11_For;
class Program
{
    static void Main(string[] args)
    {
        /*
     For kullanımı:
     for(tip dongu_degiskeni=deger; dongu_degiskeni<tekrar_sayisi; dongu_degiskeni artış/azalış)
        */

        /*    for (int i = 1; i < 6; i++)
           {
               //Buraya yazılacak kodlar 5 kez çalıtırılacaktır.
               System.Console.WriteLine($"{ i}.Merhaba Bright");
       } */

        //1 ile 10 arasındaki sayıları ekrana yazdıralım.

        /*  for (int i = 1; i < 11; i++)
         {
             System.Console.WriteLine(i);
         } */
        //a'dan z'ye tüm harfleri ekrana yazdır.
        /* for (char i = 'a'; i <= 'z'; i++)
        {
            System.Console.WriteLine(i);
        } */
        //İlk beşi ters sırada yazdıralım.
        /*  for (int i = 5; i >= 1; i--)
         {
             System.Console.WriteLine($"{i}. kişi.");
         } */

        //ekrana girilen sayı kadar merhaba yazdıralım.
        /*  Console.Write("Kaç kez merhaba yazılsın?");
         int adet = Convert.ToInt32(Console.ReadLine());
         for (int i = 1; i <=adet; i++)
         {
             Console.WriteLine("Merhaba");
         } */

        /* for(int i = 1; i<=5; ){
            //kısır döngüdür. çünkü i<=5 ten sonra ne kadar tekrar etmesi gerektiğini söylemedik.
        } */

        //1 ile 10 arasındaki sayıların toplamını ekrana yazdıralım.

        /*   int toplam = 0;
          for (int i = 1; i <= 10; i++)
          {
              toplam += i;
          }
          System.Console.WriteLine($"Toplam: {toplam}"); */

        /* int toplam = 0;
        for (int i = 2; i <= 10; i++)
        {
            toplam += i;
        }
        System.Console.WriteLine($"Çift Sayıların Toplaım: {toplam}"); */
        /* int ciftToplam = 0;
        int tekToplam = 0;
        for (int i = 2; i <= 10; i += 2)
        {
            ciftToplam += i;
            tekToplam += i - 1;
        }
        System.Console.WriteLine($"Çift Sayıların Toplaım: {ciftToplam}");
        System.Console.WriteLine($"Tek Sayıların Toplaım: {tekToplam}"); */

        //1-10 arasındaki sayıları alt alta listelerken yanlarında tek mi yoksa çift mi oldukları yazsın.


        /*  for (int i = 2; i <= 10; i += 2)
         {
             System.Console.WriteLine($"{i - 1}: Tek Sayı.");
             System.Console.WriteLine($"{i}: Çift Sayı.");
         } */

        //1-10 arasındaki sayıları alt alta listelerken yanlarında tek mi yoksa çift mi oldukları yazsın. İKİNCİ YOL.

        /* int tekToplam = 0;
        int ciftToplam = 0;

        for (int i = 0; i <= 10; i++)
        {
            if (i % 2 == 1) tekToplam += i; else ciftToplam += i;
        }
        System.Console.WriteLine($"Tek sayıları toplamı: {tekToplam}.");
        System.Console.WriteLine($"Çift sayıların toplamı: {ciftToplam}."); */

        //Klavyeden girilecek 2 sayı arasındaki sayıları ekrana yazdırın. Her birinin yanında 3 ya da 3ün katı olup olmadığını belirtin ve 3 ya da 3 ün katı olan sayıların toplamını ekrana yazdırın.

        /* Console.Write("Birinci sayıyı girin: ");
        int sayi1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("İkinci sayıyı girin: ");
        int sayi2 = Convert.ToInt32(Console.ReadLine());
        int toplam = 0;

        for (int i = sayi1; i <= sayi2; i++)
        {
            if (i % 3 == 0)
            {
                Console.WriteLine($"{i}: 3'ün katıdır. ");
                toplam += i;
            }
            else
            {
                System.Console.WriteLine(i);
            }
        }
        System.Console.WriteLine($"3'ün katı sayılarının toplamı: {toplam}"); */

        //klavyeden girilecek bir sayıya kadar olan sayılardan kaç tanesinin çift kaç tanesinin 3ün katı olduğunu yazdırın.

        /*  System.Console.Write("Birinci sayıyı girin: ");
         int sayi1 = Convert.ToInt32(Console.ReadLine());
         System.Console.Write("İkinci sayıyı girin: ");
         int sayi2 = Convert.ToInt32(Console.ReadLine());
         int toplamUc = 0;
         int toplamIki = 0;

         for (int i = sayi1; i <= sayi2; i++)
         {
             if (i % 3 == 0)
             {
                 toplamUc++;
             }
             if (i % 2 == 0)
             {
                 toplamIki++;
             }
         }
         System.Console.WriteLine($"{sayi1} ile {sayi2} arasında {toplamUc} adet 3'ün katı sayı vardır.");
         System.Console.WriteLine($"{sayi1} ile {sayi2} arasında {toplamIki} adet 2'nin katı sayı vardır."); */

        //Kullanıcının gireceği sayılardan kaç tanesinin 100'den küçük ya da 100'e eşit olduğunu buldurup ekrana yazdıralım. Uygulama kullanıcı 0 girene kadar çalışmaya devam edecek. 0 girdiğinde sonucu yazıp bitecek.

        /*  int adet = 0;
         int i = 1;
         int sayi;
         for (; ; )
         {
             Console.Write($"{i}. sayıyı giriniz: ");
             sayi = Convert.ToInt32(Console.ReadLine());
             if (sayi == 0)
             {
                 break;
             }
             if (sayi >= 100)
             {
                 adet++;
                 i++;
             }
         }
         System.Console.WriteLine($"Girilen sayılardan {adet} adedi 100'den büyük ya da eşittir."); */

        //kullanıcı klavyeden 1 sayı girsin ardından bu sayının kaçıncı kuvvetini bulmak istediğini girsin. bizim uygulamamız bu işlemin sonucunu bulsun. ***not: math.pow yok!!1!1!!!1!

        Console.Write("Kuvvetini almak istediğiniz sayıyı giriniz: ");
        int sayi = Convert.ToInt32(Console.ReadLine());
        Console.Write("Kuvveti giriniz: ");
        int kuvvet = Convert.ToInt32(Console.ReadLine()); //ipucu küp almak istiyorsanız (toplam *= toplam)

        for(int i = sayi; i<=sayi; i++)
        {
            
        }

    }
}
