using BooksApp.Data.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksApp.Data.Concrete
{
    public class Author:BaseEntity
    {
        public List<Book> Books { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Url { get; set; }
        public string Abstract { get; set; }
        public string PhotoUrl { get; set; }
    }
}
