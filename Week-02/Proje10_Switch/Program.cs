namespace Proje10_Switch;
class Program
{
    static void Main(string[] args)
    {
        /*  int x = 25;
         switch (x)
         {
             case 5:
             Console.WriteLine("Bugün ayın beşi");
             break;
             case 10:
             Console.WriteLine("Bugün ayın onu");
             break;
             case 15:
             Console.WriteLine("Bugün ayın onbeşi");
             break;
             default:
             Console.WriteLine("Bugün o gün değil");
             break;
         } */
        /*
        x değerini aşağıdaki değerkere göre grubunu yazalım:
        5-10 --> Sayı 5-10 arasındadır.
        11-20 --> Sayı 11-25 arasındadır.
        21-30 --> Sayı 21-30 arasındadır.
        Bu aralıklardan biri değilse, satyı aralık dışıdır.
        */

        /*         int x = 15;
                string mesaj = "";
                switch (x)
                {
                    case >=5 and <=10:
                        mesaj="Sayı 5-10 arasındadır.";
                    break;
                    case >=11 and <=20:
                        mesaj="Sayı 11-20 arasındadır.";
                    break; 
                    case >=21 and <=30:
                        mesaj="Sayı 21-30 arasındadır.";
                    break;
                    default: 
                    mesaj="Sayı aralık dışıdır.";
                    break;
                }
                Console.WriteLine(mesaj); */

        /* int x = 30;
        string mesaj= "";

        if (x>=5 && x<=10)
        {
            mesaj="Sayı 5-10 arasındadır.";
        } else if (x>=11 && x<=20){
            mesaj="Sayı 11-20 arasındadır.";
        } else if (x>=21 && x<=30) {
            mesaj = "Sayı 21-30 arasındadır.";
        } else
        {
            mesaj="Sayı aralık dışıdır.";
        }
        Console.WriteLine(mesaj);*/

        /*
        İçinde bulunduğumuz günün haftaiçi mi yoksa haftasonu mu olduğunu bulup ekrana yazalım.
        */
        /*
                DateTime bugun = new DateTime(2023, 2, 18);
                   switch (bugun.DayOfWeek) //Haftanın gününün index numarasını verir.
                  {
                      case DayOfWeek.Saturday:
                      case DayOfWeek.Sunday: 
                      Console.WriteLine("Hafta sonundasınız.");
                      break;
                      default:
                      Console.WriteLine("Hafta içindesiniz.");
                      break;
                  } */
        /*         if (bugun.DayOfWeek == DayOfWeek.Sunday || bugun.DayOfWeek == DayOfWeek.Saturday)
                {
                    Console.WriteLine("Hafta sonundasınız. Dinlenebilirsiniz.");
                }
                else
                {
                    Console.WriteLine("Hafta içindesiniz. Çalışmaya devam.");
                } */

        //Klavyeden girilen bir sayı 20-30 arasında ise veya günlerden pazartesi ise ekrana "Bingo! Kazandınız!" yazsın.
        //Böyle değilse kaybettiniz yazsın.

        Console.Write("Bir sayı giriniz: ");
        int sayi = Convert.ToInt32(Console.ReadLine());
        DateTime bugun = new DateTime(2023, 2, 13);

        /* if (sayi >= 20 && sayi <= 30 || bugun.DayOfWeek == DayOfWeek.Monday) //Ve'nin işlem önceliği vardır. Veya'yı öncelendirmek istiyorsan matematikteki gibi parantez içine al.
        {
            Console.WriteLine("Bingo! Kazandınız!");
        }
        else
        {
            Console.WriteLine("Kaybettiniz.");
        } */

        //Günlerden pazartesi veye salı ise ve sayı 50'den büyülse ekrana kazandınız, değilse kaybettiniz.

        if ((bugun.DayOfWeek == DayOfWeek.Monday || bugun.DayOfWeek == DayOfWeek.Tuesday || bugun.DayOfWeek == DayOfWeek.Wednesday) && sayi >= 50 && 100 >= sayi)
        {
            Console.WriteLine("Kazandınız.");
        }
        else
        {
            Console.WriteLine("Kaybettiniz.");
        }
    }
}
