using BooksApp.Data.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksApp.Data.Concrete
{
    public class Publisher:BaseEntity
    {
        public string Name { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public List<Book> PublisherBooks { get; set; }
    }
}
