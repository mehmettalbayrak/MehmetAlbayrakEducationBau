﻿using Proje.EFCore;

// GetAllCustomers();
// GetAllCustomersContactNames();
// GetAllCustomers2();
// GetAllCustomersFromSpain();
// GetProductsForBeveragesCategory();
// GetProductsForBeveragesCategory2();
// GetOrdersForGermany();
// GetOrdersOfEmployeesInLondon();
// GetLastInsertedFiveProducts();
// GetProductsPrice10to15();
// AveragePriceBeverages();
// CountBeveragesCondiments(); 
// GetLikeTofu();
GetMaxMinPriceProduct();

//En yüksek fiyatlı ve en düşük fiyatlı ürünleri listeleyelim.

static void GetMaxMinPriceProduct()
{
    using (_AppDbContext context = new _AppDbContext())
    {
        //Önce max fiyatı bulalım.
        var maxPrice = context
                            .Products
                            .Max(p => p.UnitPrice);
        //Min fiyat.
        var minPrice = context
                            .Products
                            .Min(p => p.UnitPrice);

        var maxProducts = context
                                .Products
                                .Where(p => p.UnitPrice == maxPrice)
                                .Select(p => new
                                {
                                    p.ProductName,
                                    p.UnitPrice
                                })
                                .OrderBy(p => p.ProductName)
                                .ToList();
        var minProducts = context
                                .Products
                                .Where(p => p.UnitPrice == minPrice)
                                .Select(p => new
                                {
                                    p.ProductName,
                                    p.UnitPrice
                                })
                                .OrderBy(p => p.ProductName)
                                .ToList();
        System.Console.WriteLine("En düşük Fiyatlı Ürünler:");
        foreach (var p in minProducts)
        {
            System.Console.WriteLine($"{p.ProductName}, {p.UnitPrice}");
        }
        System.Console.WriteLine("En yüksek Fiyatlı Ürünler:");

        foreach (var p in maxProducts)
        {
            System.Console.WriteLine($"{p.ProductName}, {p.UnitPrice}");
        }
        Console.ReadLine();
    }
}

//Adının içinde tofu ifadesi geçen ürünlerin listesini ad ve fiyat olarak alalım.

// static void GetLikeTofu()
// {
//     using (_AppDbContext context = new _AppDbContext())
//     {
//         var result = context
//                         .Products
//                         .Where(p=>p.ProductName.Contains("tofu"))
//                         .Select(x=> new {
//                             x.ProductName, x.UnitPrice
//                         })
//                         .ToList();
//         foreach (var p in result)
//         {
//             System.Console.WriteLine($"{p.ProductName}, {p.UnitPrice}");
//         }
//         Console.ReadLine();
//     }
// }

//Beverages ve Condiments kategorilerinde toplam kaç adet ürün vardır?

// static void CountBeveragesCondiments()
// {
//     using (_AppDbContext context = new _AppDbContext())
//     {
//         var result = context
//                         .Products
//                         .Where(p => p.Category.CategoryName == "Beverages" || p.Category.CategoryName == "Condiments")
//                         .ToList();
//         System.Console.WriteLine(result.Count);
//         Console.ReadLine();
//     }
// }

//Beverages kategorisindeki ürünlerin ortalama fiyatını bulalım.
// static void AveragePriceBeverages()
{
    using (_AppDbContext context = new _AppDbContext())
    {
        var result = context
                        .Products
                        .Where(p => p.Category.CategoryName == "Beverages")
                        .Average(p => p.UnitPrice);
        System.Console.WriteLine(result);
    }
}



//Fiyatı 10-15 arasında olan ürünleri ad ve fiyatlarıyla fiyata göre büyükten küçüğe sıralı olarak listeleyelim.

// static void GetProductsPrice10to15()
// {
//     using (_AppDbContext context = new _AppDbContext())
//     {
//         var result = context
//                         .Products
//                         .Where(p => p.UnitPrice >= 10 && p.UnitPrice <= 15)
//                         .Select(p => new
//                         {
//                             p.ProductName,
//                             p.UnitPrice
//                         })
//                         .OrderByDescending(p => p.UnitPrice)
//                         .ToList();
//         foreach (var p in result)
//         {
//             System.Console.WriteLine($"{p.ProductName}, {p.UnitPrice}");
//         }
//     }
// }

//Products tablosuna son eklenen 5 productı listeleyelim

// static void GetLastInsertedFiveProducts()
// {
//     using (_AppDbContext context = new _AppDbContext())
//     {
//         var result = context
//                             .Products
//                             .OrderByDescending(p => p.ProductId)
//                             .Take(5)
//                             .OrderBy(p => p.ProductId)
//                             .ToList();
//         foreach (var s in result)
//         {
//             System.Console.WriteLine($"{s.ProductId},{s.ProductName}");
//         }
//         Console.ReadLine();
//     }
// }

//London'daki çalışanlarımızın yaptığı satışları listeleyelim.

// static void GetOrdersOfEmployeesInLondon()
// {
//     using (_AppDbContext context = new _AppDbContext())
//     {
//         var result = context
//                         .Orders
//                         .Where(o => o.Employee.City == "London")
//                         .Select(o => new { o.Customer.City, o.OrderId, o.OrderDate })
//                         .ToList();

//         foreach (var c in result)
//         {
//             System.Console.WriteLine($"{c.OrderId},{c.OrderDate},{c.City}");
//         }
//         System.Console.WriteLine(result.Count);
//         Console.ReadLine();
//     }
// }

//Germany'deki müşterilere yaptığımız satışları listeleyelim.

// static void GetOrdersForGermany()
// {
//     using (_AppDbContext context = new _AppDbContext())
//     {
//         var result = context
//                             .Orders
//                             .Where(o => o.Customer.Country == "Germany")
//                             .Select(o => new { o.OrderId, o.OrderDate, o.Customer.Country, o.Customer.CompanyName })
//                             .ToList();
//         foreach (var o in result)
//         {
//             System.Console.WriteLine($"{o.OrderId}, {o.OrderDate}, {o.Country}, {o.CompanyName}");
//         }
//         Console.ReadLine();
//     }
// }

//GetProductsForBeveragesCategory adlı metodu yazın. Bu metod sadece Beverages kategorisindeli ürünleri listelesin.

// static void GetProductsForBeveragesCategory2()
// {
//     using (_AppDbContext context = new _AppDbContext())
//     {
//         var result = context
//                             .Products
//                             .Where(p => p.Category.CategoryName == "Beverages")
//                             .ToList();
//         foreach (var product in result)
//         {
//             System.Console.WriteLine($"{product.ProductName}, {product.UnitPrice}");
//         }
//         Console.ReadLine();
//     }
// }

//GetProductsForBeveragesCategory adlı metodu yazın. Bu metod sadece Beverages kategorisindeli ürünleri listelesin. Not: Beverages CategoryId'si 1.

// static void GetProductsForBeveragesCategory()
// {
//     using (_AppDbContext context = new _AppDbContext())
//     {
//         var products = context
//                             .Products
//                             .Where(p => p.CategoryId == 1)
//                             .ToList();
//         foreach (var product in products)
//         {
//             System.Console.WriteLine($"{product.ProductName}");
//         }
//         Console.ReadLine();
//     }
// }

// static void GetAllCustomersFromSpain()
// {
//     using (_AppDbContext context = new _AppDbContext()) //garbage collector'e bırakmadan uygulamadan çıkılır çıkılmaz verilerin öldürülmesini ve performans arttırımını sağlar. 
//     {
//         var customers = context
//                             .Customers
//                             .Select(c => new { c.CompanyName, c.Country, c.ContactName })
//                             .Where(c => c.Country == "Spain")
//                             .ToList();
//         foreach (var customer in customers)
//         {
//             System.Console.WriteLine($"{customer.CompanyName},{customer.ContactName}");
//         }
//         Console.ReadLine();
//     }
// }

// /// <summary>
// /// Bütün müşterileri list customer tipinde getirir.
// /// </summary>
// //  static void GetAllCustomers2()
// {
//     _AppDbContext context = new _AppDbContext();
//     List<Customer> customers = context
//                                     .Customers
//                                     .Select(c => new Customer
//                                     {
//                                         CustomerId = c.CustomerId,
//                                         CompanyName = c.CompanyName,
//                                         ContactName = c.ContactName
//                                     }).ToList();
//     foreach (var customer in customers)
//     {
//         System.Console.WriteLine($"{customer.CustomerId},{customer.CompanyName},{customer.ContactName}");
//     }
//     Console.ReadLine();
// }

// // static void GetAllCustomersContactNames()
// {
//     _AppDbContext appDbContext = new _AppDbContext();
//     var customers = appDbContext.Customers.Select(c => new { c.ContactName, c.Country }).ToList(); //Customers datasının içinde dolaş her kayıt için c de. Sonra o c'leri şunu yap demek.
//     foreach (var customer in customers)
//     {
//         System.Console.WriteLine($"{customer.ContactName}, {customer.Country}");
//     }
//     Console.ReadLine();
// }

// // static void GetAllCustomers()
// {
//     _AppDbContext _appDbContext = new _AppDbContext();
//     //LINQ sorguları
//     List<Customer> customers = _appDbContext.Customers.ToList(); //Adonette yaptığımız sql server bağlantısı açma, çalıştırma, execute etme verileri tek tek okuma o verileri bir döngü içine bir listeye atma gibi işlemleri yapan kod.
//     foreach (var customer in customers)
//     {
//         System.Console.WriteLine($"{customer.CustomerId},{customer.CompanyName}");
//     }
//     Console.ReadLine();
// }