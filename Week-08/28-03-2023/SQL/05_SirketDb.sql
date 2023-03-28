USE MASTER
GO

DROP DATABASE IF EXISTS SirketDb
GO

CREATE DATABASE SirketDb
GO

USE SirketDb
GO

CREATE TABLE Departmanlar
(
	Id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	Ad NVARCHAR(MAX) NOT NULL
)
GO

INSERT INTO Departmanlar
	(Ad)
VALUES
	('Muhasebe'),
	('Teknik'),
	('Satış'),
	('İK'),
	('Yönetim')
GO

CREATE TABLE Unvanlar
(
	Id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	Ad NVARCHAR(50) NOT NULL
)
GO

INSERT INTO Unvanlar
	(Ad)
VALUES
	('İşçi'),
	('Muhasebe Uzmanı'),
	('Satışçı'),
	('İK Uzmanı'),
	('İK Stajyeri'),
	('Yönetici'),
	('Yönetici Yardımcısı')
GO

CREATE TABLE Iller
(
	Id CHAR(2) NOT NULL PRIMARY KEY,
	Ad NVARCHAR(30) NOT NULL
)
GO

INSERT INTO Iller
	(Id, Ad)
VALUES
	('34', 'İstanbul'),
	('06', 'Ankara'),
	('35', 'İzmir'),
	('58', 'Sivas'),
	('41', 'İzmit')
GO

CREATE TABLE Ilceler
(
	Id INT PRIMARY KEY NOT NULL IDENTITY(1,1),
	Ad NVARCHAR(30) NOT NULL,
	IlId CHAR(2) NOT NULL,
	FOREIGN KEY(IlId) REFERENCES Iller(Id)
)
GO

INSERT INTO Ilceler
	(Ad, IlId)
VALUES
	('Kadıköy', '34'),
	('Beşiktaş', '34'),
	('Avcılar', '34'),
	('Konak', '35'),
	('Yenimahalle', '06'),
	('Çankaya', '06'),
	('Suşehri', '58')
GO

CREATE TABLE Personeller
(
	Id INT PRIMARY KEY NOT NULL IDENTITY(1,1),
	Ad NVARCHAR(25) NOT NULL,
	Soyad NVARCHAR(25) NOT NULL,
	Cinsiyet BIT NOT NULL,
	DogumTarihi DATE NOT NULL,
	IkametgahIlceId INT NOT NULL,
	IseBaslamaTarihi DATE NOT NULL,
	DepartmanId INT NOT NULL,
	UnvanId INT NOT NULL,
	Maas MONEY NOT NULL,
	FOREIGN KEY(IkametgahIlceId) REFERENCES Ilceler(Id),
	FOREIGN KEY(DepartmanId) REFERENCES Departmanlar(Id),
	FOREIGN KEY(UnvanId) REFERENCES Unvanlar(Id)
)
GO

INSERT INTO Personeller
	(Ad, Soyad, Cinsiyet, DogumTarihi, IkametgahIlceId, IseBaslamaTarihi,
	DepartmanId, UnvanId, Maas)
VALUES
	('Alican', 'Kabak', 0, '1999-05-15', 1, '2021-11-10', 1, 4, 12500),
	('Sude', 'Canöz', 1, '1999-05-15', 2, '2021-11-10', 2, 5, 22500),
	('Yaşar', 'Tel', 0, '1999-05-15', 3, '2021-11-10', 3, 6, 32500),
	('Kemal', 'Faraba', 0, '1999-05-15', 4, '2020-11-10', 4, 7, 12800),
	('Zeliha', 'Gülenyüz', 1, '1999-05-15', 5, '2020-11-10', 5, 7, 12000),
	('Armanc', 'Ekşisurat', 1, '1999-05-15', 6, '2020-11-10', 1, 6, 17500),
	('Kadriye', 'İpçeken', 1, '1999-05-15', 7, '2018-11-10', 2, 5, 15000),
	('Fatih', 'Elebakan', 0, '1999-05-15', 1, '2018-11-10', 3, 4, 18500),
	('Kaya', 'Kurtlutepe', 0, '1999-05-15', 2, '2015-11-10', 4, 3, 19500),
	('Selçuk', 'Tepe', 0, '1999-05-15', 3, '2015-11-10', 5, 2, 16500),
	('Arda', 'Güler', 0, '1999-05-15', 4, '2015-11-10', 1, 1, 33500)
GO

CREATE TABLE Projeler
(
	Id INT PRIMARY KEY NOT NULL IDENTITY(1,1),
	Ad NVARCHAR(50) NOT NULL,
	BaslamaTarihi DATE NOT NULL,
	PlanlananBitisTarihi DATE NOT NULL
)
GO

INSERT INTO Projeler
	(Ad, BaslamaTarihi, PlanlananBitisTarihi)
VALUES
	('Mutlu Çocuklar', '2022-5-5', '2022-8-5'),
	('Temiz Üsküdar', '2022-5-5', '2022-8-5'),
	('Kirli Kadıköy', '2022-5-5', '2022-8-5'),
	('Haydi Gençler Elele', '2022-5-5', '2022-8-5')
GO

CREATE TABLE Gorevlendirmeler
(
	ProjeId int FOREIGN KEY REFERENCES Projeler(Id),
	PersonelId int FOREIGN KEY REFERENCES Personeller(Id),
	CONSTRAINT [PK_ProjePersonel] PRIMARY KEY CLUSTERED
	(
		ProjeId, PersonelId
	) ON [PRIMARY]
)
GO
INSERT INTO Gorevlendirmeler
VALUES
	(1, 1),
	(1, 2),
	(2, 3),
	(2, 4),
	(3, 3),
	(3, 4),
	(4, 1),
	(4, 3)
GO