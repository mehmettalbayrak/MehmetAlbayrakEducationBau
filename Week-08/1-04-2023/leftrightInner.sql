--Hangi kategoride ka� �r�n var?

--select CategoryName as [Kategori], COUNT(*) as [�r�n Adedi]
--from Categories c
--		inner join Products p on c.CategoryID=p.CategoryID
--group by c.CategoryName
--order by [�r�n Adedi]

--Hangi �lkeye ne kadarl�k sat�� yapm���z?

--select c.Country, sum(od.UnitPrice*od.Quantity) as total
--	from orders o
--			inner join OrderDetails od on o.OrderID = od.OrderID
--				inner join Customers c on o.CustomerID=c.CustomerID
--group by c.Country
--order by total desc

--Hangi �lkeye ka� kez kargo yollam���z?
--select o.ShipCountry, count(*) as Adet
--from orders o
--	group by o.ShipCountry
--	order by o.ShipCountry

--Elimizde en �ok sto�u bulunan ilk �� �r�n ve stok miktarlar�?

--select top(3) p.ProductName, p.UnitsInStock
--	from Products p
--	order by p.UnitsInStock desc