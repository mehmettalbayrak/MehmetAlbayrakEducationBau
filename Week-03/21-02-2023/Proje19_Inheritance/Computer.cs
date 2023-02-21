using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje19_Inheritance
{
    public class Computer : Product
    {
        public Computer()
        {

        }
        public Computer(int ram)
        {
            Ram = ram;
        }

        public Computer(int ram, int screenSize, string keyboardType)
        {
            Ram = ram;
            ScreenSize = screenSize;
            KeyboardType = keyboardType;
        }

        public int Ram { get; set; }
        public int ScreenSize { get; set; }
        public string KeyboardType { get; set; }
    }
}
