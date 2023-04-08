#region Komutlar
// Entity Framework Core paketini yükleme komutu (Sql Server için):
//dotnet add package Microsoft.EntityFrameworkCore.SqlServer
//(Sqlite için)
//dotnet add package Microsoft.EntityFrameworkCore.Sqlite
//EFCore paketini kaldırma komutu (sql):
//dotnet remove package Microsoft.EntityFrameworkCore.Sqlite    

/*
NugetPackageManager eklentisi ile de yüklenebilir.
Eğer sistemde daha önce yüklü değilse ef tool'u yüklenir.
EF tool yükleme komutu:
dotnet tool install --global dotnet-ef

EFCore Design paketini yükleme komutu:
dotnet add package Microsoft.EntityFrameworkCore.Design

-Dotnet sql database bağlantı oluşturma:
dotnet ef dbcontext scaffold "Server=DESKTOP-E30TBPJ;Database=Northwind;User=sa;Password=123;TrustServerCertificate=True" Microsoft.EntityFrameworkCore.SqlServer --context AppDbContext
*/
#endregion

Console.WriteLine("Hello, World!");
