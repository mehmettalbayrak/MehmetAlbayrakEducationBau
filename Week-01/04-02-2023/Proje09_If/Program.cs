namespace Proje09_If
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // If kullanım şekilleri:

            /*
            1- if (koşul) işlem;
            2- if(koşul)
            {
                işlemler;
            }
            3- if (koşul)
            {
                işlemler;
            } else 
            {
                işlemler;
            }
            */

            /* int yas = 16;
             *//*if (yas >= 18) Console.WriteLine("Giriş yapabilirsiniz.");   // tek eşittir atama çift eşittir karşılaştırma operatörüdür.*//*
             if (yas>=18)
             {
                 Console.WriteLine("Giriş yapabilirsiniz.");
             } else 
             {
                 Console.WriteLine("Giriş yapamazsınız.");
             }*/
            /*
                        Console.Write("Yaşınızı giriniz: ");
                        int yas = Convert.ToInt32(Console.ReadLine());
                        if (yas > 18)  
                        {
                            Console.WriteLine("Giriş yapabilirsiniz.");
                        }
                        else if (yas<18)
                        {
                            Console.WriteLine("Giriş yapamazsınız.");
                        }
                        else
                        {
                            Console.WriteLine("Veliniz ile birlikte gelin.");
                        }*/

            //klavyeden 2 sayı girilmesini ve bu iki sayıdan büyük olanın sonuç olarak ekrana girilmesini sağlayın. not: math.max metodunu kullanmayın.

            Console.Write("Birinci sayıyı giriniz: ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("İkinci sayıyı giriniz: ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            if (sayi1 > sayi2)
            {
                Console.WriteLine(sayi1);
            }
            else if (sayi2 > sayi1)
            {
                Console.WriteLine(sayi2);
            }
            else
            {
                Console.WriteLine("İki sayı birbirine eşit!"); //ctrl+k, d komutu kodun yazılımı düzelir.
            }

        }
    }
}