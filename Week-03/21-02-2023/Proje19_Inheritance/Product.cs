using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje19_Inheritance
{
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public virtual double KDV()//Virtual; miras verdiği classda eğer istenilirse verilen method ezilebilir.
        {
            double kdv = Price * 1.18;
            return kdv; //Şu nada bununla tüm productlara default olarak %18 oranında KDV uygulanıyor.
        }

        public void PrintProduct() 
        {
            Console.WriteLine($"{Name}, {Price}, {KDV()}");
        }
    }
}
