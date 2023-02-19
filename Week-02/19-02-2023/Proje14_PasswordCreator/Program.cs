namespace Proje14_PasswordCreator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string karakterler = "abcdefghijklmnoprystuvyzx0123456789+-.,";
            string harfler =  "abcdefghijklmnoprystuvyzx" ;
            string rakamlar =  "0123456789" ;
            string ozelKarakterler =  "+-.," ;
            string geciciSifre = "";

            Random random = new Random();
            string harf = harfler[random.Next(1, harfler.Length)].ToString();
            geciciSifre += harf;

            string rakam = rakamlar[random.Next(1, harfler.Length)].ToString();
            geciciSifre += rakam;

            string ozelKarakter = ozelKarakterler[random.Next(1, ozelKarakterler.Length)].ToString();
            geciciSifre +=ozelKarakter;

            string[] harfler2 = new string[3];
            for (int i = 0; i < harfler2.Length; i++)
            {
                harfler2[i] = harfler[random.Next(1, harfler.Length)].ToString() ;
                geciciSifre += harfler2[i];
            }

            Console.WriteLine(geciciSifre);

            string sifre = geciciSifre[0].ToString();
            int siraNo = 0;
            int[] indexler = new int[6];
            for (int i = 1; i < geciciSifre.Length; i++) 
            {
                do
                {
                    siraNo = random.Next(1, geciciSifre.Length);

                } while (indexler.Contains(siraNo));
                indexler[i] = siraNo;   
                sifre += geciciSifre[siraNo];

                
    
            }

            for (int i = 1; i < indexler.Length; i++)
            {
                sifre += geciciSifre[indexler[i]];
            }

            Console.WriteLine(sifre);
        }
    }
}