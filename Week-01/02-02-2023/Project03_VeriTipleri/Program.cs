namespace Project03_VeriTipleri
{
    class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }    
        public decimal Price { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region VeriTipleri
            /*
             * //Tamsayılar
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

             Random random = new Random();
             Product urun = new Product(); //Kodun en başında class kısmında "Product" adında bir class oluşturduk ve bu classa urun isimli bir değişken tanımladık.
             urun.Id = 1; //başta oluşturduğumuz Product classına Id, Name ve Price isimli objeler tanımladık ve bunlara değerler verdik.
             urun.Name = "iPhone 14";
             urun.Price = 34500;
             Console.WriteLine(urun.Id + ", " + urun.Name + ", " + urun.Price); //son olarak canlıda görüntüledik.
            */
            #endregion
            #region Dönüştürme
            /* byte a = 5;
             int b = a; //convert işlemi. byte olan 5'i int tipine değiştirdi. Eğer 5 değilde byte boyutunu aşacak olan 355 yazsaydık 355'i byte yapamayacağı için error verecekti. buna da implict convert denir yani örtülü dönüştürme.
             long c = b;
             long d = 4580;
             int e = (int)d; //unboxing işlemi: herhangi bir objenin içindeki değeri dışarı çıkartır. Eğer değer fazla gelirse veri kabı yaşanabilir.
             int sayi = 512;
             byte sayi2 = (byte)sayi;
             Console.WriteLine(sayi2);
             int sayi3 = 155;
             byte sayi4 = Convert.ToByte(sayi3); // yukarıdaki unboxing metoduyla aynı işi yapar.
             string sayiMetin = "75";
             Console.WriteLine(sayiMetin / 2); // String olduğu için bölünmek bunun için stringden çevirmemiz gerekir.
             byte sayi5 = byte.Parse(sayiMetin);
             Console.WriteLine((decimal)(sayi5 / 2)); //stringden parse yöntemiyle değiştirdikten sonra çıkan sonuç tamsayı olmayabileceği için decimal komutunu da kullanarak canlıda ondalık sayı olarak da sonuç verebilmesini sağlayacaktır.*/
            #endregion

            //int girilenDeger = int.Parse(Console.ReadLine());

            /*Console.Write("Birinci sayıyı giriniz: ");
            int sayi1 = int.Parse(Console.ReadLine());

            Console.Write("İkinci sayıyı giriniz: ");
            int sayi2= int.Parse(Console.ReadLine());

            int sonuc = sayi1 + sayi2;
            Console.WriteLine("Sonuç: " + sonuc);*/
            //F11 komutu ile kullanırsak, konsol açılıp satır satır yazdığımız kodu f11'e bastıkça çalıştıracaktır. console.write komutunda yazdığımız "değer girin kısmında" değer vererek en sonki işlemde sonuç sonucunu verecektir.

            Console.Write("Birinci sayıyı giriniz: ");
            int sayi3 = int.Parse(Console.ReadLine());

            Console.Write("İkinci sayıyı giriniz: ");
            int sayi4 = int.Parse(Console.ReadLine());

            Console.Write("Üçüncü sayıyı giriniz: ");
            int sayi5 = int.Parse(Console.ReadLine());  


            decimal sonuc2 = (decimal)(sayi3 + sayi4 + sayi5)/3;
            Console.WriteLine("Sonuç: " + sonuc2);

        }
    }
}