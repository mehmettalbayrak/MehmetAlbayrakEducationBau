using Microsoft.EntityFrameworkCore;

namespace Proje.Models
{
    public class AppContext:DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
