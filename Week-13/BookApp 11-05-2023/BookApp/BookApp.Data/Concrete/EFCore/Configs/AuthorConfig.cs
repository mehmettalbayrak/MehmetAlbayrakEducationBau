using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksApp.Data.Concrete.EFCore.Configs
{
    public class AuthorConfig : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.HasKey(a => a.Id);
            builder.Property(a => a.Id);
            builder.Property(a => a.FirstName);
            builder.Property(a => a.LastName);
            builder.Property(a => a.Url);
            builder.Property(a => a.Abstract);
            builder.Property(a => a.PhotoUrl);
            builder.ToTable("Authors");
        }
    }
}
