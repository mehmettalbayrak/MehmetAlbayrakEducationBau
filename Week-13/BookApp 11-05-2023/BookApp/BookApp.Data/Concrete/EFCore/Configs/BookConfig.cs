using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksApp.Data.Concrete.EFCore.Configs
{
    public class BookConfig : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id);
            builder.Property(p => p.Name).IsRequired().HasMaxLength(125);
            builder.Property(p => p.Properties).IsRequired().HasMaxLength(528);
            builder.Property(p => p.Url).IsRequired().HasMaxLength(258);
            builder.Property(p => p.ImageUrl).IsRequired();
            builder.Property(p => p.Price).IsRequired();
            builder.Property(p => p.PageCount);
            builder.Property(p => p.IsDeleted);
            builder.Property(p => p.IsHome);
            builder.Property(p => p.AuthorId).IsRequired();
            builder.Property(p => p.PublisherId).IsRequired();
            builder.Property(p => p.Stock);

            builder.ToTable("Books");

        }
        

    }
}
