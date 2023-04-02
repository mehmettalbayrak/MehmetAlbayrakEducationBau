--Hangi bölgede hangi üründen ne kadarlýk satýþ yapýlmýþtýr?
--select r.RegionDescription, p.ProductName, sum (od.UnitPrice*od.Quantity) as TOTAL
--from Region r
--		inner join Territories t on r.RegionID = t.RegionID
--			inner join EmployeeTerritories et on t.TerritoryID=et.TerritoryID
--				inner join Employees e on et.EmployeeID = e.EmployeeID
--					inner join orders o on o.EmployeeID = e.EmployeeID
--						inner join OrderDetails od on od.OrderID = o.OrderID
--							inner join Products p on p.ProductID = od.ProductID
--group by r.RegionDescription, p.ProductName
--having sum (od.UnitPrice*od.Quantity)>10000
--order by r.RegionDescription

--Hiç satýþ yapýlmamýþ müþterilerin listesi
--Hiç satýþ YAPMAMIÞ çalýþanlarýn listesi

--select c.CompanyName, sum (od.UnitPrice*od.Quantity) as TOTAL
--from Customers c
--		left join Orders o on c.CustomerID = o.CustomerID --left custumers right ordersý teslim ediyor (yazým sýrasýna göre)
--			left join OrderDetails od on o.OrderID = od.OrderID
--group by c.CompanyName having sum (od.UnitPrice*od.Quantity) is null
--order by TOTAL

select e.FirstName + '' +e.LastName as Çalýþan 
	from Employees e
		left join orders o on e.EmployeeID = o.EmployeeID
	group by e.FirstName + '' +e.LastName having count(o.EmployeeID) = 0
	