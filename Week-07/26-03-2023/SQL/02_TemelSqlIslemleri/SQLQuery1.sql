--SQL komutları büyük/küçük harf duyarlı değildir.
--Örneğin Use ile use aynı işi yapar.
use master
go

drop database if exists ECommerceQuery
go

create database ECommerceQuery
go

use ECommerceQuery
go

create table Categories(
	Id int not null primary key identity(1,1), 
	Name nvarchar(50),
	Description nvarchar(100)
)
go

insert into Categories(Name) values
('Telefon'),
('Beyaz eşya'),
('Elektronik')
go

create table Products(
	Id int not null primary key identity(1,1),
	Name nvarchar(50) not null,
	Price decimal(10, 2) not null,
	CategoryId int not null,
	foreign key(CategoryId) references Categories(Id)
)
go

insert into Products (Name, Price, CategoryId) values
('iPhone 13', 23000, 1),
('iPhone 14', 33000, 2),
('iPhone 15', 43000, 3),
('iPhone 16', 53000, 1),
('Samsung 13', 20000, 1),
('Samsung 14', 22000, 2),
('Vestel 13', 13000, 2),
('Vestel 13', 20000, 3),
('Sırma Su', 10, 1)
