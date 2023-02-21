using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje19_Inheritance
{
    public class Mobile:Product
    {
        //Mobileların KDV oranı %8.
        public string BatteryType { get; set; }
        public int Size { get; set; }
        public override double KDV() //override; miras alınan product classında ezilmesini istediğimiz bir method vardı ve onun için virtual kullanmıştık. ezilmesini tamamlamak için override komutunu yaptık. Yani miras verilen methodu override etik.
        {
            return Price * 1.08;
        }
    }
}
