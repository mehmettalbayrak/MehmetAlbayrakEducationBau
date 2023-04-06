using Proje.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.DAL.Abstract
{
    public interface IProductDAL:IGenericDAL<Product>
    {
        public List<Product> GetProductsByCategory(string categoryName);
    }
}
