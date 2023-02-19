namespace Proje13_Diziler
{
    internal class Program
    {

        static void DiziyiYazdir(int[] dizi)
        {
            for (int i = 0; i < dizi.Length; i++)
            {
                Console.Write($"{dizi[i]}\t");
            }
        }
        /*static int SesliHarfAdedi(string ifade)
        {
            *//* //Selam
             char[] sesliHarfler = { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü' };
             int sesliHarfAdedi = 0;
             ifade = ifade.ToLower();
             for (int i = 0; i < ifade.Length; i++)
             {
                 if (sesliHarfler.Contains(ifade[i]))
                 {
                     sesliHarfAdedi++;
                 }
             }*/
        /*return sesliHarfAdedi;
        static int[] SayiUret() //Neden parantez açıp kapattığımızı OOP kısmında anlayacağız.
        {
            int[] sayilar = new int[10];
            Random random = new Random();

            for (int i = 0; i < sayilar.Length; i++)
            {
                sayilar[i] = random.Next(1, 101);
                *//*Console.WriteLine($"{i + 1}. değer: {sayilar[i]}");*//*
            }*//*
            return sayilar;
        }*/




        static void Main(string[] args)
        {
            #region MyRegion
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

            /* string[] isimler = new string[4];
             isimler[0] = "Ayşen";
             isimler[1] = "Umay";
             isimler[2] = "Ceyda";
             isimler[3] = "Begüm";*/

            /* for (int i = 0; i < isimler.Length; i++)
             {
                 isimler[i] += "Ergül";
                 //isimler[i] = isimler [i] + "Ergül"
             }

             //foreach kullanıldığında içinde dolaşılan collection üzerinde değişiklik yapılamaz.

             foreach (var isim in isimler) //tip belirtmek istemediğimiz durumlarda var yazabiliriz.
             {
                 Console.WriteLine(isim);
             }*/

            /* Random rastgele = new Random();
             int rastgeleSayi = rastgele.Next();
             int rastgeleSayi2 = rastgele.Next(10, 101);

             Console.WriteLine(rastgeleSayi);
             Console.WriteLine(rastgeleSayi2);*/

            /*int[] sayiDizisi = SayiUret();
            int enb = sayiDizisi.Max();
            DiziyiYazdir(sayiDizisi);
            Console.WriteLine(enb);

            int[] yeniSayiDizisi = SayiUret();
            int enb2 = yeniSayiDizisi.Max();
            DiziyiYazdir(yeniSayiDizisi);
            Console.WriteLine(enb2);

            Console.WriteLine(sayiDizisi.Min());
            Console.WriteLine("En Büyük: " + sayiDizisi.Max());
            Console.WriteLine("En Küçük: " + sayiDizisi.Min());

            Array.Sort(sayiDizisi);
            DiziyiYazdir(sayiDizisi);

            Console.WriteLine();
            Array.Reverse(sayiDizisi);
            DiziyiYazdir(sayiDizisi);*/

            #endregion
            #region SesliHarfAdediBulma
            //Klavyeden girilecek bir metindeki sesli harf sayısının bulup ekrana yazdıran metodu hazırlayalım.

            /* Console.Write("Bir ifade giriniz: ");
             string ifade = Console.ReadLine();
             int adet = SesliHarfAdedi(ifade);
             Console.WriteLine($"Sonuç: {ifade} ifadesinde {adet} adet sesli harf bulunmaktadır.");*/

            #endregion

            /*#region KelimeAdediBulma
           //Klavyeden girilecek bir cümledeki tine klavyeden girilecek bir sözcüğün kaç kez geçtiğini bulalım.
           Console.Write("Bir ifade giriniz: ");
            string ifade = Console.ReadLine();

            Console.Write("Kaç kez geçtiğini öğrenmek istediğiniz sözcüğü giriniz: ");
            string sozcuk = Console.ReadLine();

            Console.Write("Küçük/büyük duyarlı olsun mu? (E/H): ");
            string caseSensitive = Console.ReadLine();

            int adet = SozcukAdedi(ifade, sozcuk);
            Console.WriteLine($"{ifade} ifadesinde {sozcuk} sözcüğü {adet} adet geçmektedir.");

            #endregion
            static int SozcukAdedi(string metin, string arananMetin)
            {
                if (caseSensitive == "H")
                {
                    metin = metin.ToLower();
                    arananMetin = arananMetin.ToLower();
                }
                string[] diziMetin = metin.Split(" "); //metin ismindeki harf değerlerine bak ve boşluğa geldiğinde ayrıştır ve dizi haline getirir.
                int adet = 0;
                for (int i = 0; i < diziMetin.Length; i++)
                {
                    if (diziMetin[i] == arananMetin) adet++;
                }
                return adet;
            }*/

            #region ŞifreOluşturma
            //içinde türkçe karakterler hariç, tüm küçük harflar, 0-9 arası rakamlar, nokta(.), virgül(,), artı(+) ve eksi (-) karakterleri bulunabilecek toplam uzunluğu 6 karakter olacak bir rastgele şifre üreten metodu yazınız.

            /* string karakterler = "abcdefghijklmnoprstuvyz0123456789.,+-";
             Random random = new Random();
             string cevap = "";
             do
             {
                 Console.Clear();
                 string sifreOlustur = "";
                 for (int i = 0; i < 6; i++)
                 {
                     sifreOlustur += karakterler[random.Next(0, karakterler.Length)];
                 }

                 Console.WriteLine(sifreOlustur);
                 do
                 {
                     Console.Write("Yeniden şifre oluşturmak istiyor musunuz? (E/H): ");
                     cevap = Console.ReadLine();
                     if (cevap != "H" && cevap != "E") Console.Clear();
                 } while (cevap != "E" && cevap != "H");
             } while (cevap == "E");*/

            //Şifre mutalaka harfle başlasın.
            //Şifrenin içinde mutlaka bir adet rakam olsun.
            //Şifrenin içinde mutlaka bir özel karakter olsun (+,-,.,",",)
            //Kalan kısmı harf olsun.
            //Tamamen büyük harf olmasın.
            //Toplam 6 karakter olsun.
            //Şifre içinde herhangi bir karakter sadece 1 kez geçsin.

            string harfler = "abcdefghijklmnoprstuvyz";
            
            string rakamlar = "0123456789";
            string ozelKarakterler = ".,+-";

            Random random = new Random();
            string cevap = "";


            string sifre = harfler[random.Next(0, harfler.Length)].ToString();
            for (int i = 0; i < 6; i++)
            {

            }

            Console.WriteLine(sifre);


            #endregion


        }
    }
}

