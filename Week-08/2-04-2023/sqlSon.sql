--Hangi b�lgede hangi �r�nden ne kadarl�k sat�� yap�lm��t�r?
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

--Hi� sat�� yap�lmam�� m��terilerin listesi
--Hi� sat�� YAPMAMI� �al��anlar�n listesi

--select c.CompanyName, sum (od.UnitPrice*od.Quantity) as TOTAL
--from Customers c
--		left join Orders o on c.CustomerID = o.CustomerID --left custumers right orders� teslim ediyor (yaz�m s�ras�na g�re)
--			left join OrderDetails od on o.OrderID = od.OrderID
--group by c.CompanyName having sum (od.UnitPrice*od.Quantity) is null
--order by TOTAL

select e.FirstName + '' +e.LastName as �al��an 
	from Employees e
		left join orders o on e.EmployeeID = o.EmployeeID
	group by e.FirstName + '' +e.LastName having count(o.EmployeeID) = 0
	