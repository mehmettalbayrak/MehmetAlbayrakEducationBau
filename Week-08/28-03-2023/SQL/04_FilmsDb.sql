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
--END create films

--START create stars
create table Stars(
    Id int not null PRIMARY key identity(1,1),
    Name nvarchar(50) not NULL,
    Gender char(1) not NULL,
    CreatedDate datetime DEFAULT getdate()
)
GO

insert into Stars
    (Name, Gender)
VALUES
    ('Mortensen', 'E'),
    ('Orlando Bloom', 'E'),
    ('Christopher Lee', 'E'),
    ('Liv Tyler', 'K'),
    ('Kıvanç Tatlıtuğ', 'E'),
    ('Halit Ergenç', 'E')
GO

--END create stars

--Start create categories
    create table Categories(
        Id int not null PRIMARY key identity(1,1),
        Name nvarchar(50) not null,
        DESCRIPTION NVARCHAR(100)
    )
    GO

    insert into Categories(Name) VALUES
    ('Komedi'), ('Roantik'), ('Distopya'),('Bilim Kurgu'), ('Aksiyon')
    GO


--END create categories

--START film categories
    create TABLE FilmCategories (
        FilmId int not NULL, 
        FOREIGN KEY(FilmId) REFERENCES Films(Id),
        CategoryId int not NULL,
        FOREIGN KEY(CategoryId) REFERENCES Categories(Id),
        CONSTRAINT [PK_FilmCategory] PRIMARY KEY CLUSTERED --kısıt yaratma
        (
            FilmId, CategoryId
        ) on [PRIMARY]
    )

--END film categories

--START FilmStars
create table FilmStars(
    FilmId int not null FOREIGN key REFERENCES Films(Id),
    StarId int not null FOREIGN key REFERENCES Stars(Id),
    CONSTRAINT [PK_FilmStar] PRIMARY KEY CLUSTERED(
        FilmId, StarId
    ) on [PRIMARY]
)


--END FilmStars