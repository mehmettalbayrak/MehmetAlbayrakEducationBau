--Data tablosundaki tüm kayýtlar

--Select *
--From Data

--Select d.[AD SOYAD] as [Ad Soyad], d.[AYRILIS TARIHI] as [Ayrýlýþ Tarihi], d.[CINSIYET KODU] as [Cinsiyet Kodu] 
--From Data d

--Kadýn çalýþanlardan, 6 numaralý mesleðe mensup olanlarýn listesi;

--select *
--from data d
--where d.[CINSIYET KODU]='F' and d.[MESLEK ID] = 6

--Kadýn çalýþanlardan, 6 numaralý mesleðe mensup olanlarýn sayýsý;
--select count(*)
--from data d
--where d.[CINSIYET KODU]='F' and d.[MESLEK ID] = 6 

--8 ve 9 numaralý mesleðe, mensup aktif kadýn çalýþanlarýn yaþ ortalamasý?

--select AVG(d.YAS) as [YAS ORTALAMASI]
--from data d
--where d.UCRET='' and d.[CINSIYET KODU]='F' and (d.[MESLEK ID] = 8 or d.[MESLEK ID] = 9)

--DATA tablosundaki MeslekID'lerinin listesi

--select distinct d.[MESLEK ID]
--from data d
--order by d.[MESLEK ID]

--Erkek çalýþanlardan maaþý 10000'den büyük olanlarýn ad ve soyad bilgisini ve maaþý getirin.

--select d.[AD SOYAD],d.UCRET
--from data d
--where d.[CINSIYET KODU]='M' and d.UCRET>10000
--order by d.UCRET desc

--Erkek çalýþanlardan maaþý 10000'den küçük olanlarýn ad ve soyad bilgisini ve maaþý getirin.

--select d.[AD SOYAD],d.UCRET
--from data d
--where d.[CINSIYET KODU]='M' and d.UCRET>10000 and d.UCRET!='' --stringlerden sayýlardan küçük olarak algýlandýðý için ücreti boþ olanlarý da çýkýyor. Bunu önlemek için sondakini yazdýk. 0'dan büyük de yazabilirdik.
--order by d.UCRET desc

--2005 yýlýnda iþe baþlyanlar
--select d.[AD SOYAD], d.[BASLANGIC TARIHI],YEAR(d.[BASLANGIC TARIHI]) as YIL
--from data d
--where YEAR(d.[BASLANGIC TARIHI])=2005

--Kadýn çalýþanlardan, aktif olanlarýn ücreti 6000 ile 8000  arasomda olanlarýn adlarýný iþe baþlama yýlý ile listeleyin

--select d.[AD SOYAD], d.[CINSIYET KOU], d.UCRET
--from data d
--where d.[CINSIYET KODU]='F' and d.UCRET>=6000 and d.UCRET<=8000 and d.UCRET!=''
--1) Erkek çalþanlarýn en yüksek maaþý
--2) Kadýn çalýþanlardan 2006 yýlýnda iþe girenlerin maaþ ortalamasý
--3) 2008-2012 arasýnda iþe girenlerin yaþ ortalamasý
--4) Aktif kadýn personel sayýsý
--5) Emekli olmadan iþten ayrýlanlarý listele
-- Kadýnlar için: 60 ve üstü yaþýnda olanlar
-- Erkekler için: 60 ve üstü yaþýnda olanlar emekli olarak ayrýlmýþlar

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