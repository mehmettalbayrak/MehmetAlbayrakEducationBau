using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Proje15_OOP_ClassPropertyField
{
    public class Personel
    {
        private string ad;

        public string Ad
        {
            get { return ad.ToUpper(); }
            set { ad = value; }
        }

        private int yas;
        private string yasGrubu = "";
        public string Yas
        {
            get
            {
                switch (yas)
                {
                    case (< 18):
                        yasGrubu = "18 yaş altı.";
                        break;
                    case (< 25):
                        yasGrubu = "25 yaş altı.";
                        break;
                    case (< 40):
                        yasGrubu = "40 yaş altı.";
                        break;
                    default:
                        yasGrubu = "40 yaş üstü.";
                        break;
                }
                return yasGrubu;
            }
            set { yas = int.Parse(value); }
        }


    }
}
