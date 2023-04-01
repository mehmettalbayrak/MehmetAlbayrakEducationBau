--2015 y�l�nda yap�lan sat��lar� listeleyelim.
--select *
--from sales s
--where year(s.OrderDate)=2015

--Sat�ld��� ay kargosu yap�lan sat��lar�n listesi

--select *
--from sales s
--where MONTH(s.OrderDate)=MONTH(s.ShipDate)

--2016 nisan ay�nda yap�lan sat��lar�n listesi
--select *
--from Sales s
--where YEAR(s.OrderDate)=2016 and MONTH(s.OrderDate)=4

--2015 y�l�n�n son �eyre�inde yap�lan sat��lar

--select *
--from Sales s
--where YEAR(s.OrderDate)=2015 and MONTH(s.OrderDate) in (10,11,12) --between 10 and 12 de diyebiliriz.

--R4 b�lgesindeki 2015 y�l�n�n ilk ve son �eyre�inde yap�lan sat���lar�n adetini bul

--select count(*)
--from sales s
--where 
--s.RegionId='R4' and
--year(s.OrderDate)=2015 and
--(month(s.OrderDate) between 1 and 3 or 
--month(s.OrderDate) between 10 and 12)

--Snacks �r�n�n�n bug�ne kadar toplam sat�� adedi
--select SUM(s.UnitsSold) as Adet
--from sales s
--where s.ItemId='I1'

--Items tablosundaki c harfi ile ba�layan �r�nlerin listesi

select *
from Items i
where i.ItemType like 'c%'