--Projeler tablosuna şu kaydı ekleyin:
--Ad: Kentsel Barışım, Başlama Tarihi:'2022-8-13' Bitiş Tarihi: '2023-3-13'

-- INSERT INTO Projeler VALUES
-- ('Kentsel Barışım', '2022-8-13','2023-3-13')

--Id'si 5 olan projenin adının Kentsel Dönüşümler olarak güncellenmesini sağlayalım.
-- UPDATE Projeler
-- set Ad = 'Kentsel Dönüşümler'

--Ürünlere 50% zam yapalım.
use Northwind
UPDATE Products
set UnitPrice=UnitPrice*1.5