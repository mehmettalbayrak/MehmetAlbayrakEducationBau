--Tüm select sorguları geriye bir tablo döndürür! 
--SELECT * FROM Products
--SELECT ProductName, UnitPrice FROM Products
--SELECT products.ProductName, products.UnitPrice FROM products
--SELECT P.ProductName, P.UnitPrice FROM Products P
--SELECT P.ProductName, p.UnitPrice FROM Products p
--SELECT e.FirstName AS Ad, e.LastName AS Soyad from Employees e
--SELECT e.FirstName AS [First Name], e.LastName AS [Last Name] from Employees e

-- SELECT *
-- FROM Products
-- WHERE UnitPrice>50

-- SELECT * 
-- FROM OrderDetails O
-- WHERE O.ProductID = 11

-- SELECT *
-- FROM Customers c
-- WHERE c.ContactName='Maria Anders'

-- SELECT c.CompanyName, c.ContactName, c.City
-- FROM Customers c
-- WHERE c.City='London'

-- SELECT *
-- FROM OrderDetails od
-- WHERE od.UnitPrice>17 and od.ProductID=11

-- SELECT *
-- FROM Customers c
-- WHERE c.Country='Mexico' OR c.Country='Germany'

-- SELECT Od.ProductID, od.UnitPrice, od.Quantity, od.UnitPrice*od.Quantity as Total
-- FROM OrderDetails Od
-- WHERE Od.UnitPrice*Od.Quantity>10000

--Toplam satış tutarı 5000-10000 arasında olan kayıtlar
-- SELECT Od.ProductID, od.UnitPrice, od.Quantity, od.UnitPrice*od.Quantity as Total
-- FROM OrderDetails Od
-- WHERE Od.UnitPrice*od.Quantity>=5000 and od.UnitPrice*od.Quantity<=10000

-- SELECT Od.ProductID, od.UnitPrice, od.Quantity, od.UnitPrice*od.Quantity as Total
-- FROM OrderDetails Od
-- WHERE Od.UnitPrice*od.Quantity BETWEEN 5000 and 10000

-- SELECT * 
-- FROM Customers c
-- WHERE c.City!='Madrid'

-- SELECT *
-- FROM Customers c
-- WHERE c.City IN('Madrid','Leipzig','Berlin','London')

--Customerlardan ContactName A harfi ile başlayanlar
-- SELECT * FROM Customers WHERE ContactName LIKE 'a%' --yüzde işareti a harfi olsun geri kalanı ne olursa olsun anlamına gelmektedir. an% yapıp ilk harfi an olsun geri kalanı ne olursa olsun gibi de düşünebilir ve türetebilriz.
--Customerlardan ContactName içinde 'ton' ifadesi geçenler
-- SELECT * FROM Customers WHERE ContactName LIKE '%ton%' --isminde ton yazanları bulma

--Tekil bir harfi kontrol etme. Customer dan ContactName'inin ikinci harfi a olanlar

-- SELECT * from Customers WHERE ContactName like '_a%' --alt çizde yüzdeki gibi hepsine değil tek karaktere bakar. Örnektekinde ilk karakteri bakmayıp ikinci harfi a olanlara bakar yüzde ile de geri kalanları ne olursa olsun deriz.
-- SELECT *
-- from Customers C
-- ORDER BY c.ContactName ASC -- a-z sıralama

-- SELECT *
-- from Customers C
-- ORDER BY c.ContactName Desc --Z-A sıralama

--Customers tablosunun country kolonuna göre A-Z sıralayalım
-- SELECT * 
-- FROM Customers C
-- ORDER BY c.Country, c.City

--Kaç adet ürünümüz var?
-- SELECT COUNT(*) AS Adet
-- from Products

-- SELECT COUNT(c.Region) as Regions --COUNT yalnızca null olmayanları sayar (içi dolu olanları)
-- FROM Customers c

--Ürünlerin ortalama birim fiyatları ne kadar?
-- select AVG(p.UnitPrice) as [Ortalama Birim Fiyat]
-- from Products p

-- SELECT SUM(p.UnitPrice) / COUNT(*) as [Ortalama Birim Fiyat]
-- FROM Products p
--EN düşük ürün fiyatı ve en yüksek ürün fiyatı?
-- SELECT MIN(p.UnitPrice) as Minimum, MAX(p.UnitPrice) as Maximum
-- FROM Products p

--String uzunluğunu bulma, ilk iki harfini bulma
-- SELECT e.FirstName, LEN(e.FirstName) as Uzunluk, LEFT(e.FirstName, 2)
-- FROM Employees e

-- SELECT e.FirstName, UPPER(e.FirstName), LOWER(e.FirstName)
-- FROM Employees e

SELECT p.QuantityPerUnit, REPLACE(p.QuantityPerUnit, 'pkgs.', 'PAKET') as [Yeni Kolon]
FROM Products p