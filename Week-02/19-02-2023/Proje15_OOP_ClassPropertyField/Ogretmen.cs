using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje15_OOP_ClassPropertyField
{
    public class Ogretmen:Personel
    {
        //Personel classındaki tüm özellik ve metodlar Ogretmen classına da aktarılmıştır. Ancak burada gözükmez.
        public string Brans { get; set; }
    }
}
