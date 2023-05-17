using BooksApp.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksApp.Entity.Concrete
{
    public class Author:BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int BirthOfYear { get; set; }
        public string Url { get; set; }
        public string Abstract { get; set; }
        public string PhotoUrl { get; set; }
        public List<Book> Books { get; set; }
    }
}
