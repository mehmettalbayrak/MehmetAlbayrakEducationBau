--Data tablosundaki t�m kay�tlar

--Select *
--From Data

--Select d.[AD SOYAD] as [Ad Soyad], d.[AYRILIS TARIHI] as [Ayr�l�� Tarihi], d.[CINSIYET KODU] as [Cinsiyet Kodu] 
--From Data d

--Kad�n �al��anlardan, 6 numaral� mesle�e mensup olanlar�n listesi;

--select *
--from data d
--where d.[CINSIYET KODU]='F' and d.[MESLEK ID] = 6

--Kad�n �al��anlardan, 6 numaral� mesle�e mensup olanlar�n say�s�;
--select count(*)
--from data d
--where d.[CINSIYET KODU]='F' and d.[MESLEK ID] = 6 

--8 ve 9 numaral� mesle�e, mensup aktif kad�n �al��anlar�n ya� ortalamas�?

--select AVG(d.YAS) as [YAS ORTALAMASI]
--from data d
--where d.UCRET='' and d.[CINSIYET KODU]='F' and (d.[MESLEK ID] = 8 or d.[MESLEK ID] = 9)

--DATA tablosundaki MeslekID'lerinin listesi

--select distinct d.[MESLEK ID]
--from data d
--order by d.[MESLEK ID]

--Erkek �al��anlardan maa�� 10000'den b�y�k olanlar�n ad ve soyad bilgisini ve maa�� getirin.

--select d.[AD SOYAD],d.UCRET
--from data d
--where d.[CINSIYET KODU]='M' and d.UCRET>10000
--order by d.UCRET desc

--Erkek �al��anlardan maa�� 10000'den k���k olanlar�n ad ve soyad bilgisini ve maa�� getirin.

--select d.[AD SOYAD],d.UCRET
--from data d
--where d.[CINSIYET KODU]='M' and d.UCRET>10000 and d.UCRET!='' --stringlerden say�lardan k���k olarak alg�land��� i�in �creti bo� olanlar� da ��k�yor. Bunu �nlemek i�in sondakini yazd�k. 0'dan b�y�k de yazabilirdik.
--order by d.UCRET desc

--2005 y�l�nda i�e ba�lyanlar
--select d.[AD SOYAD], d.[BASLANGIC TARIHI],YEAR(d.[BASLANGIC TARIHI]) as YIL
--from data d
--where YEAR(d.[BASLANGIC TARIHI])=2005

--Kad�n �al��anlardan, aktif olanlar�n �creti 6000 ile 8000  arasomda olanlar�n adlar�n� i�e ba�lama y�l� ile listeleyin

--select d.[AD SOYAD], d.[CINSIYET KOU], d.UCRET
--from data d
--where d.[CINSIYET KODU]='F' and d.UCRET>=6000 and d.UCRET<=8000 and d.UCRET!=''
--1) Erkek �al�anlar�n en y�ksek maa��
--2) Kad�n �al��anlardan 2006 y�l�nda i�e girenlerin maa� ortalamas�
--3) 2008-2012 aras�nda i�e girenlerin ya� ortalamas�
--4) Aktif kad�n personel say�s�
--5) Emekli olmadan i�ten ayr�lanlar� listele
-- Kad�nlar i�in: 60 ve �st� ya��nda olanlar
-- Erkekler i�in: 60 ve �st� ya��nda olanlar emekli olarak ayr�lm��lar

--select max(d.UCRET) as Ucret
--from data d
--where d.[CINSIYET KODU]='M' and UCRET!=''

--select AVG(CAST(d.UCRET as float))
--from data d
--where d.[CINSIYET KODU]='F' and YEAR(d.[BASLANGIC TARIHI])=2006 and UCRET!=''

--select AVG(d.YAS)
--from data d
--where YEAR(d.[BASLANGIC TARIHI]) between 2008 and 2012

--select COUNT(*)
--from data d
--where d.UCRET!='' and d.[CINSIYET KODU]='F'

select *
from data d
where d.UCRET='' and (d.[CINSIYET KODU]='F' and d.YAS<60 or d.[CINSIYET KODU]='M' and d.YAS<65)