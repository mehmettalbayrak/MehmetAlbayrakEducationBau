namespace Proje08_HataKontrolu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region TryCatchAçıklama
            /*
            *Uygulamalarımız çalıştıkları esnada bir takım hatalardan dolayı durdurulurlar. 
            *Bu tür hatalar çalışırken meydana geldikleri için RunTime errors deriz. 
            *Run time errorsu kontrol altına alabilmek için kullanacağımız yapı Try-catch-finally yapısı olacak.
             */
            try
            {
                //normalde çalışmasını istediğimiz ve hata verme olasılığı olan kodları buraya yazağız. Yani C#'a bu kodları çalıştırmayı dene. 
                //Eğer hata yoks catch bloğu es geçilir. Hata varsa da catch bloğuna yönlendirilir.
            }
            catch (Exception ex) //exeption kısmına bir değişken tanımladık. bu değişken genellikle "ex" olarak isimlendirilir.
            {
                //try bloğunda çalıştırmayı denediği kodlarda bir hata meydana geldiyse buraya yazılan kodlar çalışır. 
                //throw; bu bölümü genellikle siliyoruz. çünkü eğer hata verirse bundan dolayı programı keser. biz kesmesini istemiyoruz.
            }
            #endregion



            /*Console.Write("Lütfen karesi alınacak sayıyı giriniz: ");
            try
            {
                int sayi = int.Parse(Console.ReadLine());
                int sonuc = Convert.ToInt32(Math.Pow(sayi, 2));
                Console.WriteLine(sonuc);
            }
            catch (Exception hata)
            {
                *//*Console.WriteLine("Hatalı veri girişi yaptınız.");*//*
                Console.WriteLine(hata.Message);
            }
            //yukarıdaki örnekte hatalı giriş yapılsa bile bir bilgilendirme metni geleceği için artık hatayı kontrol altına almış oluruz.
            */

            try
            {
                Console.Write("Birinci sayıyı giriniz: ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.Write("İkinci sayıyı giriniz: ");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(a/b);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Sıfır ile bölme işlemi yapılamaz.");
            }
            catch (FormatException ex) 
            {
                Console.WriteLine("Lütfen bir sayı giriniz.");
            }
            catch(Exception ex) 
            {
                Console.WriteLine("Bilinmeyen bir hata oluştu.");
            }
        }
    }
}