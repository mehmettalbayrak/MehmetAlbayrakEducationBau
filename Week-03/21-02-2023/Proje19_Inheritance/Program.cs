namespace Proje19_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mobile mobile1 = new Mobile();
            mobile1.Name = "iPhone 13";
            mobile1.Price = 20000;
            /* Console.WriteLine($"{mobile1.Name} - {mobile1.Price} - {mobile1.KDV()}");*/
            mobile1.PrintProduct();

            Computer computer1 = new Computer();
            computer1.Name = "MacBook Air M2";
            computer1.Price = 20000;
            computer1.Ram = 16;
            /* Console.WriteLine($"{computer1.Name} - {computer1.Price} - {computer1.Ram} - {computer1.KDV()}");*/
            computer1.PrintProduct();
        }
    }
}