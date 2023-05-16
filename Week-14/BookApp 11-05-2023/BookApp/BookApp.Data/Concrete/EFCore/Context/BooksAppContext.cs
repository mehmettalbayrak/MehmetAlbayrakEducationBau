using BooksApp.Data.Concrete.EFCore.Configs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksApp.Data.Concrete.EFCore.Context
{
    public class BooksAppContext:DbContext
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<BookCategory> BookCategories { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Publisher> Publishers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=BooksApp.db");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<Author>(new AuthorConfig());
            modelBuilder.ApplyConfiguration<Book>(new BookConfig());
            modelBuilder.ApplyConfiguration<Category>(new CategoryConfig());
            modelBuilder.ApplyConfiguration<BookCategory>(new BookCategoryConfig());
            modelBuilder.ApplyConfiguration<Publisher>(new PublisherConfig());
            base.OnModelCreating(modelBuilder);
        }
    }
}
