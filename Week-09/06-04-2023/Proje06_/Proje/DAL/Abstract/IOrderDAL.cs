using Proje.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.DAL.Abstract
{
    public interface IOrderDAL:IGenericDAL<Order>
    {
        List<Order> GetSalesByCompanyName(string companyName);
    }
}
