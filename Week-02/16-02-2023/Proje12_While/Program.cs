namespace Proje12_While;
class Program
{
    static void Main(string[] args)
    {
        /* 
        while (koşul) {
            koşul true ise yapılacak işlemler burada olacak.(döngünün içinde çalışması gereken kodlar.)
            koşul true olduğu sürece burası tekrarlanır.
        } 
        */
        /* int i = 1;
            while (i<=5){
                System.Console.WriteLine("merhaba bright");
                i++;
             }
    */

        //1 ile 10 arasındaki sayıları toplayalım.

        /* int i = 1;
        int toplam = 0;
        while (i <= 10)
        {
            toplam += i;
            i++;
        }
        System.Console.WriteLine($"Toplam: {toplam}");
 */
        //klavyeden girilecek sayıları toplayan, 0 girilince çıkmayı sağlayan ve son olarak bulduğu toplamı ekrana yazan kod.

        /*  int sayi = 1;
         int toplam = 0;
         while (sayi != 0)
         {
             System.Console.Write("Bir sayı giriniz: ");
             sayi = Convert.ToInt16(Console.ReadLine());
             toplam += sayi;

         }
         System.Console.WriteLine($"Toplam: {toplam}"); */

        /*         int sayi = 1;
                int toplam = 0;

                do {
                    System.Console.Write("Bir sayı giriniz: ");
                    sayi = Convert.ToInt16(Console.ReadLine());
                    toplam += sayi;

                } while (sayi != 0);

                System.Console.WriteLine($"Toplam: {toplam}"); 
                */

        //klavyeden girilecek sayılar arasında en büyüğünü buldurup yazın. Yani kullanıcı kendisi durmak isteyene kadar sayı girişi yapsın. Ne zaman 0 girerse uygulama dursun. Ve 0 girildikten sonra girilmiş sayıların en büyüğünü ekrana yazdırın.

        int sayi = 0;
        int enBuyuk = 0;

        for (; ; )
        {
            System.Console.Write("Bir sayı giriniz: ");
            sayi = Convert.ToInt32(Console.ReadLine());
            if (sayi == 0) break;
            if (sayi > enBuyuk) enBuyuk = sayi;
        }

        System.Console.WriteLine($"En büyük sayı: {enBuyuk}");

        /* 
            ÖDEV: (Aşağıdaki işleri for, while ve do while kullanarak ayrı ayrı yapınız.)
            1)1-100 arasındaki sayılardan hangilerinin kullanıcının gireceği bir sayıya tam olarak bölünebildiğini yazdıran programı hazırlayınız.
            2)Ekrana çarpım tablosunu yazdırınız. 
            3)Ekrandan girilen herhangi bir ifadeyi ilk harfinden başlayıp sırasıyla ve satır satır birer harf arttırarak alt alta yazdır.
         */

    }
}
