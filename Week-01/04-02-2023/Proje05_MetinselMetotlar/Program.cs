namespace Proje05_MetinselMetotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string metin = "Wissen Akademie";
            Console.WriteLine(metin.ToLower()); //terminali sağdaki solution explorerı açarak projemizin üstüne sağ tıklayarak open in terminal seçeneğini seçerek altta terminali açıyoruz. dotnet run diyerek programı çalıştırabiliriz. cls komutu terminal sayfasını temizler. çalıştırmadan önce kaydetmeyi unutma!!!
            Console.WriteLine(metin.ToUpper());
            string m1 = "Bahçeşehir";
            string m2 = "Üniversitesi";
            string sonuc = String.Concat(m1, " ", m2); //Concat'in birden fazla çözümü vardır. Buna overload denir.
            Console.Clear(); //console öncesindeki yazıları temizlemeye yarar.
            Console.WriteLine(sonuc);

            Console.Clear();
            string ad = "Kemal";
            int yas = 42;
            string meslek = "Web Geliştirici";
            /*string sonuc1 = "Merhaba! Ben " + ad + ". " + yas + " yaşındayım. " + "Meslek: " + meslek + ". ";*/
            string sonuc1 = "Ad: " + ad + "\nYaş: " + yas + "\nMeslek: " + meslek; // \n alt satıra geçirir.
            Console.WriteLine(sonuc1);
            string sonuc2 = $"Ad: {ad}\nYaş: {yas}\nMeslek: {meslek}";
            Console.WriteLine(sonuc2);
            string sonuc3 = String.Concat("Ad: ", ad, "\n", "Yaş: ", yas, "\n", "Meslek: ", meslek);
            Console.Clear();
            Console.WriteLine(sonuc3);

            Console.Clear();
            /*string kurs = "Full Stack Developer Eğitimi";
            string aranan = "Stack";
            bool varMi = kurs.Contains(aranan); //aranan değişkenin içinde belirtilen nesne var mı? diye gösteren komuttur. True ya da False olarak sonuç verir.
            string aranan = "stack";
            bool varMi = kurs.ToLower().Contains(aranan.ToLower()); //ToLower komutunu kullanarak kurs değişkeninde küçük harflerde stack stringi var mı? sorusunu sordurduk. aranana da aynısını yaparak eğer değeri büyük harflerde olsaydı küçük olarak arardı.
            Console.WriteLine(varMi);*/

            string kurs = "Full StACK Developer Eğitimi";
            string aranan = "STAck";
            bool varMi = kurs.ToLower().Contains(aranan.ToLower());
            Console.WriteLine("Orijinal Halleri");
            Console.WriteLine("*********");
            Console.WriteLine($"Kurs: {kurs}");
            Console.WriteLine($"Aranan: {aranan}");
            Console.WriteLine($"(Arama yapılırken {kurs}, {kurs.ToLower()}\n{aranan} ise {aranan.ToLower()} şeklinde kullanıldı.");
            Console.WriteLine(varMi ? "Var" : "Yok");

            Console.Clear();
            string text = "Bugün Cumartesi";
            string arananText = "i";
            Console.WriteLine(text.StartsWith(arananText)); //burada ise i harfi ile başlayan var mı ya da yok mu diye arattık.
            Console.WriteLine(text.EndsWith(arananText));

            Console.Clear();
            string adres = "Kemalpaşa mh. Solak Apt. No:12 Beşiktaş";
            int result1 = adres.IndexOf("Beşiktaş"); //Beşiktaş kelimesinin ilk harfinin sıra numarasını verdi. 
            Console.WriteLine(result1);

            //"Kemalpaşa mh. Solak Apt. No:12 Beşiktaş" adresinin içinde 24. sıradadır.
            Console.WriteLine($"\"Beşiktaş\" ifadesi \"{adres}\" adresinin içerisinde {result1}.sıradadır.");

            Console.Clear();
            string haber1 = "İstanbul'a kar yağışı geliyor.";
            string sonucHaber1 = haber1.Replace("kar", "yağmur"); //ilk yazdığızı ikinci yazdığımıza değiştirir.
            Console.WriteLine(haber1);
            Console.WriteLine(sonucHaber1);

            Console.Clear();
            string haberBasligi = "EYT'li vatandaşlara müjde! Mart ayında maaşlar yatacak!";
            //Hedef: "eytli-vatandaslara-mujde-mart-ayinda-maaslar-yatacak" oluşturmak.
            haberBasligi = haberBasligi.ToLower();
            haberBasligi = haberBasligi.Replace("ö", "o");
            haberBasligi = haberBasligi.Replace("ü", "u");
            haberBasligi = haberBasligi.Replace("ş", "s");
            haberBasligi = haberBasligi.Replace("ç", "c");
            haberBasligi = haberBasligi.Replace("ğ", "g");
            haberBasligi = haberBasligi.Replace("ı", "i");
            haberBasligi = haberBasligi.Replace("!", "");
            haberBasligi = haberBasligi.Replace("'", "");
            haberBasligi = haberBasligi.Replace("?", "");
            haberBasligi = haberBasligi.Replace(" ", "-");
            Console.WriteLine(haberBasligi);


        }
    }
}