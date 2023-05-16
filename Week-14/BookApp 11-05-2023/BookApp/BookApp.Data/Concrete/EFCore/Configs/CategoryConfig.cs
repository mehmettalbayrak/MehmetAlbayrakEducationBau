using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace BooksApp.Data.Concrete.EFCore.Configs
{
    public class CategoryConfig : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(c => c.Id); //PK olmasýný saðladýk.
            builder.Property(c => c.Id); //Identity olmasýný saðladý(birer birer artacak.
            builder.Property(c => c.Name).IsRequired().HasMaxLength(128);
            builder.Property(c => c.Description).IsRequired().HasMaxLength(528);
            builder.Property(c => c.Url).IsRequired().HasMaxLength(200);
            builder.ToTable("Categories");
        }
    }
}
