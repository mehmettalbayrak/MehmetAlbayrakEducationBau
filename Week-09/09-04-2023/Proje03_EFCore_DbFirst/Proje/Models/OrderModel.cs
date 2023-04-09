using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proje.Models
{
    public class OrderModel
    {
        public int Id { get; set; }
        public DateTime? OrderDate { get; set; }
        public decimal? Total { get; set; }
        public List<ProductModel> Products { get; set; }
    }
}