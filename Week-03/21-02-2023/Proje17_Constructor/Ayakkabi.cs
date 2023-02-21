using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje17_Constructor
{
    //Ben kimi zaman yeni bir ayakkabı oluştururken ayakkabı numarasını da vermek istiyorum.
    public class Ayakkabi
    {
        public Ayakkabi() 
        {
            
        }

        public Ayakkabi(int numara)
        {
            Numara = numara;
        }

        public string Marka { get; set; }
        public int Numara { get; set; }
        public string Cinsiyet { get; set; }


        private string durum;

        public string Durum
        {
            get 
            {
                if (Cinsiyet=="Kadın")
                {
                    durum = "Stabil";
                }
                else
                {
                    durum = "Riskli";
                }
                return durum;
            }
            set { durum = value; }
        }

    }
}
