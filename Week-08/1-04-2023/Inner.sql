--select p.ProductName as [�r�n Ad�], c.CategoryName as [Kategori Ad�]
--from Products p inner join Categories c on p.ProductID=c.CategoryID
--product name ile birlikte categori name listelensin.


--Seafood kategorisindeki �r�nlerin UnitPrice ortalamas�n� g�sterelim.
--select AVG(p.UnitPrice) as [Seafood ortalama fiyat�]
--from Products p inner join Categories c
--on p.CategoryID=c.CategoryID
--where c.CategoryName = 'Seafood'


--select sum(od.UnitPrice*od.Quantity)
--from Products p
--		inner join Suppliers s on p.SupplierID=s.SupplierID
--			inner join OrderDetails od on p.ProductID=od.ProductID
--where s.Country='Spain'

--Chai sat��lar�n�n toplam tutar�n� g�sterin

--select sum(od.UnitPrice*od.Quantity)
--from Products p 
--		inner join OrderDetails od on p.ProductID=od.ProductID
--			where p.ProductName='Chai'

--Spain ve Germany'ye sat�lan �r�nlerden Tofu ve Ikura �r�nlerinin sat�� toplam�?

--select sum(od.UnitPrice*od.Quantity)
--from Products p
--		inner join OrderDetails od on p.ProductID=od.ProductID
--			inner join Orders o on od.OrderID=o.OrderID
--			where( p.ProductName='Tofu' or p.ProductName = 'Ikura') 
--				and
--				(o.ShipCountry='Germany' or o.ShipCountry='Spain')

--Kanada'daki m��terilerin yapm�� oldu�u sat��lar�n listesi

--select distinct p.ProductName
--from Orders o
--	inner join Customers c on o.CustomerID=c.CustomerID
--		inner join OrderDetails od on od.OrderID = o.OrderID
--			inner join Products p on od.ProductID = p.ProductID
--		where c.Country = 'Canada'
--		order by p.ProductName

--Aria Cruz'a yap�lan sat�� tutarlar� toplam�

--select *
--from orders o
--		inner join Customers c on o.CustomerID = c.CustomerID
--			inner join OrderDetails od on o.OrderID=od.OrderID
--where c.ContactName='Aria Cruz'

--select c.ContactName
--from orders o
--		inner join Customers c on o.CustomerID = c.CustomerID
--			inner join OrderDetails od on o.OrderID=od.OrderID
--	order by c.ContactName

