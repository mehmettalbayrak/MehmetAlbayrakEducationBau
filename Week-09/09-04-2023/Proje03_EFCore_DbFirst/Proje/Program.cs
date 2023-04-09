using Proje.Efcore;
using Proje.Models;

// CountProductsByCategory();
// OrderByCustomers();
// GetOrderByCustomers();
GetOrderDetails();

//müşterilere göre detaylı siperişler(her sipraişin de detayları görünecek.)

static void GetOrderDetails()
{
    using (AppDbContext context = new AppDbContext())
    {
        var result = context
                        .Customers
                        .Where(c => c.Orders.Any())
                        .Select(c => new CustomerModel
                        {
                            Id = c.CustomerId,
                            Name = c.CompanyName,
                            OrderCount = c.Orders.Count,
                            Orders = c.Orders.Select(o => new OrderModel
                            {
                                Id = o.OrderId,
                                OrderDate = o.OrderDate,
                                Total = o.OrderDetails.Sum(od => od.UnitPrice * od.Quantity),
                                Products = o.OrderDetails.Select(od => new ProductModel
                                {
                                    Id = od.ProductId,
                                    Name = od.Product.ProductName
                                }).ToList()
                            }).ToList()
                        })
                        .OrderBy(x => x.OrderCount)
                        .ToList();
        foreach (var cm in result)
        {
            System.Console.WriteLine("MÜŞTERİ BİLGİLERİ");
            System.Console.WriteLine("-----------------");
            System.Console.WriteLine($"{cm.Id}, {cm.Name}, {cm.OrderCount}");
            System.Console.WriteLine($"SİPARİŞ BİLGİLERİ");
            System.Console.WriteLine("-----------------");
            foreach (var om in cm.Orders)
            {
                System.Console.WriteLine($"{om.OrderDate}, {om.Total}");
                System.Console.WriteLine("SİPARİŞ DETAYLARI");
                System.Console.WriteLine("-----------------");
                foreach (var pm in om.Products)
                {
                    System.Console.WriteLine($"{pm.Id},{pm.Name}");
                }
            }


            System.Console.WriteLine("");
            System.Console.WriteLine("");
        }
    }
    Console.ReadLine();
}

//Müşterilere göre satışlar
// static void GetOrderByCustomers()
// {
//     using (AppDbContext context = new AppDbContext())
//     {
//         var result = context
//                         .Customers
//                         .Select(c=> new CustomerModel {
//                             Id = c.CustomerId,
//                             Name = c.CompanyName,
//                             OrderCount = c.Orders.Count,
//                             Orders = c.Orders.Select(o=> new OrderModel
//                             {
//                                 Id = o.OrderId,
//                                 OrderDate = o.OrderDate
//                             }).ToList()
//                         })
//                         .ToList();
//                         foreach (var o in result)
//                         {
//                             System.Console.WriteLine($"MÜŞTERİ BİLGİLERİ");
//                             System.Console.WriteLine($"{o.Id},{o.Name},{o.}");
//                         }
//     }
// }


//Müşterilerin sipariş sayılarını gösterelim.
// static void OrderByCustomers()
// {
//     using (AppDbContext context = new AppDbContext())
//     {
//         var result = context
//                         .Customers
//                         .Where(c=>c.Orders.Count>0)
//                         .Select(c=> new CustomerModel{
//                             Id=c.CustomerId,
//                             Name = c.CompanyName,
//                             OrderCount = c.Orders.Count
//                         }).OrderByDescending(x=>x.OrderCount)
//                         .ToList();
//     foreach (var c in result)
//     {
//         System.Console.WriteLine($"{c.Id}, {c.Name}, {c.OrderCount}");
//     }
//     }
//     Console.ReadLine();
// }

//Kategorilere göre ürün sayıları listeleme
// static void CountProductsByCategory()
// {
//     using (AppDbContext context = new AppDbContext())
//     {
//         var result = context
//                         .Categories
//                         .Where(c => c.Products.Count > 0)
//                         .Select(c => new CategoryModel
//                         {
//                             Id=c.CategoryId,
//                             Name=c.CategoryName,
//                             ProductCount=c.Products.Count
//                         })
//                         .ToList();
//         foreach (var c in result)
//         {
//             System.Console.WriteLine($"{c.Id},{c.Name}, {c.ProductCount}");
//         }

//     }
//     Console.ReadLine();
// }