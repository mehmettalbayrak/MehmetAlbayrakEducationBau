using Proje.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.DAL.Abstract
{
    public interface ICustomerDAL:IGenericDAL<Customer>
    {
        //Burada IGenericDAL içindeki her şey customera göre mevcut.
        //Biz buraya ayrıca customera özgü metodların imzalarını yazacağız.

    }
}
