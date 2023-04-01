--2015 yýlýnda yapýlan satýþlarý listeleyelim.
--select *
--from sales s
--where year(s.OrderDate)=2015

--Satýldýðý ay kargosu yapýlan satýþlarýn listesi

--select *
--from sales s
--where MONTH(s.OrderDate)=MONTH(s.ShipDate)

--2016 nisan ayýnda yapýlan satýþlarýn listesi
--select *
--from Sales s
--where YEAR(s.OrderDate)=2016 and MONTH(s.OrderDate)=4

--2015 yýlýnýn son çeyreðinde yapýlan satýþlar

--select *
--from Sales s
--where YEAR(s.OrderDate)=2015 and MONTH(s.OrderDate) in (10,11,12) --between 10 and 12 de diyebiliriz.

--R4 bölgesindeki 2015 yýlýnýn ilk ve son çeyreðinde yapýlan satýþþlarýn adetini bul

--select count(*)
--from sales s
--where 
--s.RegionId='R4' and
--year(s.OrderDate)=2015 and
--(month(s.OrderDate) between 1 and 3 or 
--month(s.OrderDate) between 10 and 12)

--Snacks ürününün bugüne kadar toplam satýþ adedi
--select SUM(s.UnitsSold) as Adet
--from sales s
--where s.ItemId='I1'

--Items tablosundaki c harfi ile baþlayan ürünlerin listesi

select *
from Items i
where i.ItemType like 'c%'