--START Create Database
use master
go

drop DATABASE if exists FilmsDb
go

create database FilmsDb
go

use FilmsDb
go
--END Crate Database

--START Directors table's beginning
create table Directors
(
    Id int not null PRIMARY key identity(1,1),
    Name nvarchar(50) not NULL,
    Gender char(1) not NULL,
    CreatedDate datetime DEFAULT getdate()
) 
GO

insert into Directors
    (Name, Gender)
VALUES
    ('Tarantino', 'E'),
    ('Peter Jackson', 'E'),
    ('George Clooney', 'E')
GO
--END Directors table

--START create films
create table Films
(
    Id int not null PRIMARY key IDENTITY(1,1),
    Name NVARCHAR(50) not null,
    YEAR int not null,
    DirectorId int not null,
    foreign key (DirectorId) REFERENCES Directors(Id),
    CreatedDate DATETIME DEFAULT GETDATE()
)
go

insert into Films
    (Name, Year, DirectorId)
VALUES
    ('Kaybedenler Kulübü', 2010, 1),
    ('Yüzüklerin Efendisi', 2000, 1),
    ('Masumiyet', 2010, 1),
    ('Babam ve Oğlum', 2016, 1),
    ('Harry Potter', 2010, 1),
    ('Interstellar', 2010, 1)
GO
