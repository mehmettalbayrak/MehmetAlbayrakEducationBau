use master
go

drop database if exists ETicaret
go

create database ETicaret
go

use ETicaret
go

create table Categories(
	Id int not null primary key identity (1,1),
	Name nvarchar(50) not null,
	Description nvarchar(100) not null,
	CreatedDate datetime default getdate()
)
go

insert into 
Categories(Name, Description)
values
('Genel','Hiçbir kategoriye dahil etmediðimiz ürünler burada olacak'),
('Telefon','Cep telefonlarý, sabit telefonlar, santral sistemleri vb.'),
('Elektronik','Elektronik eþyalar burada olacak'),
('Beyaz Eþya','Endüstriyel ya da ev kullanýmý için beyaz eþyalar'),
('Mobilya','Mobilya ürünleri')
go

--Herhangi bir kategori silinir se boþta kalmamasý için genel kategorisine atmak istedik. (CategoryId int not null default 1) default 1'i genel kategorisine atmak için ilk baþta genel'i yazdýðýmýz için 1 yazdýk.

create table Products(
Id int not null primary key identity(1,1),
Name nvarchar(100) not null,
Properties nvarchar(250) not null,
Price Decimal(10,2) not null,
CreatedDate Datetime default getdate(),
CategoryId int not null default 1,
FOREIGN KEY (CategoryId) references Categories(Id) on delete set default 
)
go

insert into Products(Name, Properties, Price, CategoryId) VALUES
('iPhone 13','Harika bir telefon',19800,2),
('Xaomi 11 Pro','Büyük bir telefon',9800,2),
('iPhone 14 Pro Max','Kamerasý süper bir telefon',39000,2),
('Samsung A115','Küçük ama becerikli bir telefon',12500,2),
('Nokia 3310','Efsane bir telefon',7500,2),
('AirPod','Sesin sihrini yakalatýr',8550,3),
('Elektronik Sigara','Acelesi olmayanlara önerilir',4900,3),
('VESTEL CMI Çamaþýr Makinesi','Beyazlar güvende',14750,4),
('Arçelik NF101 Buzdolabý','Beyazlar güvende',17500,4)
go
