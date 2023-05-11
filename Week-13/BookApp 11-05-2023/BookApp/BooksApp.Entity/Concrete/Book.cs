using BooksApp.Data.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksApp.Data.Concrete
{
    public class Book:BaseEntity
    {
        public bool IsHome { get; set; }
        public string Name { get; set; }
        public string Properties { get; set; }
        public string Url { get; set; }
        public string ImageUrl { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
        public int PageCount { get; set; }
        public int AuthorId { get; set; }
        public int PublisherId { get; set; }

    }
}
