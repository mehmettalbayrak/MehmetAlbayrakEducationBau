using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje17_Constructor
{
    public class Ogrenci
    {
        /// <summary>
        /// Bu yöntem ile boş bir öğrenci oluşturulabilir.
        /// </summary>
        public Ogrenci() //Boş constructor ile, mainde "new Ogrenci" yaparken parantez içine bir şey yazmamıza gerek kalmaz.
        {

        }

        /// <summary>
        /// Bu yöntem ile adını vererek bir öğrenci oluşturulabilir.
        /// </summary>
        /// <param name="name"></param>

        public Ogrenci(string name) // Consturctor: Bir klasda yeni bir nesne çalıştırmak istediğimizde kodları buraya yazıyoruz. Mainde iki tane new Ogrenci oluşturduğumuz için 2 tane verdi consolda. Constructor metodlaroının  TİPİ olmaz.cons metodunda normale aykırı olarak class ile birebir aynı olmak zorundadır. Bu metoda OVERLOAD denir.
        {
            Name = name; //Önce maindeki Ogrenci'nin içine parametre olarak string değerler atadık.
            /*Console.WriteLine(Name + "adlı öğrenci oluşturuldu...");*/
        }

        public Ogrenci(string name, string department)
        {
            Name = name;
            Department = department;
        }

        public Ogrenci(string name, string department, int age)
        {
            Name = name;
            Department = department;
            Age = age;
        }

        public string Name { get; set; }
        public string Department { get; set; }
        public int Age { get; set; }
    }
}
