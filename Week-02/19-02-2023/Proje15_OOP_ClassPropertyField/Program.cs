namespace Proje15_OOP_ClassPropertyField
{
    class Hayvan
    {
        //Property: Özellikler olacak. 
        //Methods: Bir hayvanın yapabileceği fiil ve eylemler. Örneğin; koşmak. 
        public void Kos()
        {
            Console.WriteLine("Hayvan, koştu.");
        }

        public void Beslen()
        {
            Console.WriteLine("Hayvan, beslendi.");
        }
        int bacakSayisi = 0; //Field: data yapısının bozulmasını istemediğimiz. Nasıl kullanılacağına bizim karar verdiğimiz değişken. buna public demiyoruz çünkü her zaman ulaşılmasını istemiyoruz. Örn: Kimlik numarası olarak düşünebiliriz. Diyelim ki burada bir kimlik numarası var ve ilk 6 hanesinin gözükmesini istiyoruz. Field'da kimlik numarasının tam hali, çağıracağımız zamanda ilk 6 hanesi gözükecek şekilde düşünebiliriz.

        public int BacakSayisi //propfull tab tab
        {
            get { return bacakSayisi - 1; } //Burada ise gönderdiğimiz değeri aşağıdaki kodumuza geri gönderiyor. Yani 4 girdiğimiz değeri -1 yaptığımız için 3 olarak iletiyor.
            set { bacakSayisi = value; }  //Aşağıda girdiğimiz değer ilk buraya geliyor. Burada fieldda bulunan bacakSayisi'na gönderiyor.
        }

        public string Ad { get; set; } //Burada ise eğer geri göndereceğimiz değerde bir manipülasyon yapılmayacaksa bu yöntem kullanılır. Burada özel bir field oluşturmamıza gerek yok. prop tab tab yapınca çıkar.
        public bool Cinsiyet { get; set; }

    }
    internal class Program
    {

        static void Main(string[] args)
        {
            #region Giriş
            /*Hayvan kedi = new Hayvan();
            kedi.Kos();
            kedi.BacakSayisi = 4;
            kedi.Ad = "Garfield";
            kedi.Cinsiyet = true;
            kedi.Beslen();
            Console.WriteLine(kedi.BacakSayisi);
            Console.WriteLine(kedi.Ad);
            Console.WriteLine(kedi.Cinsiyet);*/
            #endregion

            Personel personel1 = new Personel();
            //Personel personel1 = new(); Yukarıdaki ile aynı şey.
            personel1.Ad = "Selami Coşkun";
            personel1.Yas = "34";

            /* Console.WriteLine($"{personel1.Ad} - {personel1.Yas}");*/

            Ogretmen ogretmen1 = new Ogretmen();
            ogretmen1.Ad = "Selma";
            ogretmen1.Yas = "41";
            ogretmen1.Brans = "Fizik";

            /*Console.WriteLine($"{ogretmen1.Ad} - {ogretmen1.Yas} - {ogretmen1.Brans}");*/

            Memur memur1 = new Memur();
            memur1.Ad = "Kutlu";
            memur1.Yas = "39";
            memur1.Departman = "Muhasebe";

            /* Console.WriteLine($"{memur1.Ad} - {memur1.Yas} - {memur1.Departman}");*/

            Ogretmen ogretmen2 = new Ogretmen();
            ogretmen2.Ad = "Sulhi";
            ogretmen2.Yas = "49";
            ogretmen2.Brans = "Kimya";

            Memur memur2 = new Memur();
            memur2.Ad = "Kadir";
            memur2.Yas = "19";
            memur2.Departman = "Yazı İşleri";

            //Beş personeli içinde tutacak bir dizi oluşturulacak.
            Personel[] personeller = { personel1, ogretmen1, ogretmen2, memur1, memur2 };

            foreach (var personel in personeller)
            {
                Console.WriteLine($"{personel.Ad} - {personel.Yas}");
            }

        }
    }
}