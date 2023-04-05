using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.DAL
{
    public interface IGenericDAL<T> //<T> yazarak tip belirledik. Bunun içine int ya da string de yazabilirdik.
    {
        void Create(); //(C)reate
        T GetById(int id); //(R)ead
        List<T> GetAll();
        void Update(int id);//(U)pdate
        void Delete(int id);//(D)elete
        
    }
}
