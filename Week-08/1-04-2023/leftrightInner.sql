--Hangi kategoride kaç ürün var?

--select CategoryName as [Kategori], COUNT(*) as [Ürün Adedi]
--from Categories c
--		inner join Products p on c.CategoryID=p.CategoryID
--group by c.CategoryName
--order by [Ürün Adedi]

--Hangi ülkeye ne kadarlýk satýþ yapmýþýz?

--select c.Country, sum(od.UnitPrice*od.Quantity) as total
--	from orders o
--			inner join OrderDetails od on o.OrderID = od.OrderID
--				inner join Customers c on o.CustomerID=c.CustomerID
--group by c.Country
--order by total desc

--Hangi ülkeye kaç kez kargo yollamýþýz?
--select o.ShipCountry, count(*) as Adet
--from orders o
--	group by o.ShipCountry
--	order by o.ShipCountry

--Elimizde en çok stoðu bulunan ilk üç ürün ve stok miktarlarý?

--select top(3) p.ProductName, p.UnitsInStock
--	from Products p
--	order by p.UnitsInStock desc