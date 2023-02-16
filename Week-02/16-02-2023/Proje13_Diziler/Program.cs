namespace Proje13_Diziler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int not1 = 25;
            int not2 = 75;
            int not3 = 80;
            int not4 = 90;
            int toplam = not1 + not2 + not3 + not4;
            double ortalama = toplam / 4;*/

            /*int[] notlar = { 25, 75, 80, 90 };*/ //Notlar adında içinde int tipinde dört adet değer barındıran bir dizi demek.

            /*int[] notlar = new int[8]; //Notlar adında içinde 4 adet int tipinde değer barındıracak dizi.

            notlar[0] = 25;
            notlar[1] = 75;
            notlar[2] = 80;
            notlar[3] = 90;
            notlar[4] = 5;
            notlar[5] = 75;
            notlar[6] = 1;
            notlar[7] = 3;


            int toplam = 0;
            int elemanSayisi = 0;
            for (int i = 0; i < notlar.Length; i++)
            {
                toplam += notlar[i];
                if (notlar[i] != 0) elemanSayisi++;
                //toplam = toplam + notlar[i];
            }

            double ortalama = toplam / notlar.Length;
            Console.WriteLine(ortalama);*/

            //Klavyeden girilecek 3 adet sayıdan en büyüğü bulduralım.

            /* int enBuyuk = 0;
             int[] sayilar = new int[3];
             for (int i = 0; i < sayilar.Length; i++)
             {
                 Console.Write($"{i + 1}. sayıyı giriniz: ");
                 sayilar[i] = Convert.ToInt32(Console.ReadLine());
                 if (sayilar[i] > enBuyuk)
                 {
                     enBuyuk = sayilar[i];
                 }
             }
             Console.Clear();
             string mesaj = "";
             for (int i = 0; i < sayilar.Length; i++)
             {
                 mesaj = sayilar[i] == enBuyuk ? "(En Büyük)" : "";
                 Console.WriteLine($"Dizinin {i + 1}. elemanı: {sayilar[i]}{mesaj}");
             }*/

            string[] isimler = new string[4];
            isimler[0] = "Ayşen";
            isimler[1] = "Umay";
            isimler[2] = "Ceyda";
            isimler[3] = "Begüm";

            for (int i = 0; i < isimler.Length; i++)
            {
                isimler[i] += "Ergül";
                //isimler[i] = isimler [i] + "Ergül"
            }

            //foreach kullanıldığında içinde dolaşılan collection üzerinde değişiklik yapılamaz.

            foreach (var isim in isimler) //tip belirtmek istemediğimiz durumlarda var yazabiliriz.
            {
                Console.WriteLine(isim);
            }

        }

    }
}
