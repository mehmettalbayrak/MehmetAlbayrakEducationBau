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
('Genel','Hi�bir kategoriye dahil etmedi�imiz �r�nler burada olacak'),
('Telefon','Cep telefonlar�, sabit telefonlar, santral sistemleri vb.'),
('Elektronik','Elektronik e�yalar burada olacak'),
('Beyaz E�ya','End�striyel ya da ev kullan�m� i�in beyaz e�yalar'),
('Mobilya','Mobilya �r�nleri')
go

--Herhangi bir kategori silinir se bo�ta kalmamas� i�in genel kategorisine atmak istedik. (CategoryId int not null default 1) default 1'i genel kategorisine atmak i�in ilk ba�ta genel'i yazd���m�z i�in 1 yazd�k.

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
('Xaomi 11 Pro','B�y�k bir telefon',9800,2),
('iPhone 14 Pro Max','Kameras� s�per bir telefon',39000,2),
('Samsung A115','K���k ama becerikli bir telefon',12500,2),
('Nokia 3310','Efsane bir telefon',7500,2),
('AirPod','Sesin sihrini yakalat�r',8550,3),
('Elektronik Sigara','Acelesi olmayanlara �nerilir',4900,3),
('VESTEL CMI �ama��r Makinesi','Beyazlar g�vende',14750,4),
('Ar�elik NF101 Buzdolab�','Beyazlar g�vende',17500,4)
go
