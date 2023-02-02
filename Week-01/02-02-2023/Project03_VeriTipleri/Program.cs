namespace Project03_VeriTipleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Tamsayılar
            byte sayi; //değişken tanımlandı.
            sayi = 23;   //değer atandı.
            byte sayi2 = 36; //Hem tanımlandı hem de atandı.
            short sayi3 = 0;
            int sayi4 = 0;
            long sayi5 = 0;
            Console.Write("Sayi: "); //bu komut renderlarken tüm satırı değil gerektiği kadar yer kaplamasını sağlar.
            Console.WriteLine(sayi);
            Console.Write("Sayi'nin boyutu: ");
            Console.WriteLine(int.MaxValue); //MinValue yazarsak da minimum değerini gösterir.
            Console.WriteLine(sizeof(int) + " byte"); //Bu komutla veri tiplerinin kapasitesinin ne kadar olduğunu konsolumuzda görebiliriz.

            //Ondalıklı sayı.
            decimal maas = 50000;
            Console.WriteLine(decimal.MaxValue);
            Console.WriteLine(sizeof(decimal));

            //Karakter: İçindeki yalnızca tek bir karakter tutabilen veri tipi. (Rakam, işaret, cinsiyet vb.)

            char cinsiyet = 'E'; //çift tırnaklar stringler için, tek tırnak char için kullanılıyor. 
            //Metinsel (String)
            string ad = "Mehmet"; //her string bir char dizisidir. bir string 5 char demektir.
            string medeniDurum = "E";
            Console.Clear();
            Console.WriteLine(ad[0]); //JS'deki arrayle aynısı. 0 yazdığımız için Mehmet isminin ilk harfini sonuç olarak verecek. 4 yazsaydık 5. harfi sonuç olarak verecekti.

        }
    }
}