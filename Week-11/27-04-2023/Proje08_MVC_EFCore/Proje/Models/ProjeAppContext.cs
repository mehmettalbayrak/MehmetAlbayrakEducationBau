using Microsoft.EntityFrameworkCore;

namespace Proje.Models
{
    public class ProjeAppContext:DbContext
    {
        public DbSet<Category> Categories { get; set; } /*DbSet aynı zamanda veri tabanındaki tabloyu da temsil etmesini sağlıyor bundan dolayı list yerine dbset kullandık.*/
        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Buraya yazmış olduğumuz kodlar, bu klasta nesne yaratılırken yapılacak olan veri tabanı konfigirasyonu ile ilgili işleri yürütür.
            //optionsBuilder.UseSqlServer("Server=DESKTOP-E30TBPJ;Database=SampleEFCoreDb;Trusted_Connection=true;TrustServerCertificate=true;"); //Sqlserver için.
            optionsBuilder.UseSqlite("Data Source=SampleEFCore.db");
            base.OnConfiguring(optionsBuilder);
        }

    }
}
