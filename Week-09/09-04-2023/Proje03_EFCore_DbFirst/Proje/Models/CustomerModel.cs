using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proje.Models
{
    public class CustomerModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int OrderCount { get; set; }
        public List<OrderModel> Orders { get; set; }
    }
}