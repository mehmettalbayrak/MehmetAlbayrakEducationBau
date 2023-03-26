use master
go

drop database if exists EShop 
go

create database EShop 
go

use EShop
GO

create table Categories (
    Id int not null primary key identity(1,1),
    Name nvarchar(50) not null,
    Description nvarchar(100) not null
)
go

insert into Categories VALUES
('Telefon','Telefon Kategorisi'),
('ELektronik','Elektronik Kategorisi'),
('Gıda','Gıda Kategorisi')
go

create table Products (
    Id int not null primary key IDENTITY(1,1),
    Name nvarchar(50) not null,
    Price decimal(10,2) not null
)
GO

insert into Products VALUES
('iPhone 13', 17500),
('iPhone 14', 27500),
('iPhone 15', 37500),
('iPhone 16', 47500),
('iPhone 17', 57500),
('iPhone 18', 67500),
('iPhone 19', 77500),
('iPhone 20', 87500)
go

create table ProductCategories (
    Id int not null PRIMARY key IDENTITY(1,1),
    ProductId int not null,
    CategoryId int not null,
    FOREIGN KEY(ProductId) REFERENCES Products(Id),
    foreign key(CategoryId) REFERENCES Categories(Id)
)
go

INSERT into ProductCategories values 
(1,1), (1,3), 
(2,1), (2,2), (2,3),
(3,1),
(4,2),
(5,3),
(6,2), (6,3),
(7,1), (7,2),
(8,1), (8,2), (8,3)
go