CREATE DATABASE RikiDB
CREATE DATABASE ProjectDB
-- Drop DATABASE AdamProject
USE ProjectDB
USE RikiDB

IF OBJECT_ID('GAMERESULTS') IS NOT NULL
DROP TABLE GAMERESULTS;

IF OBJECT_ID('HERO') IS NOT NULL
DROP TABLE HERO;

IF OBJECT_ID('VILLAIN') IS NOT NULL
DROP TABLE VILLAIN;

select * from Hero

GO

CREATE TABLE GAMERESULTS(
    GameResultsID int PRIMARY KEY,
    Created DATETIME,
    WinnerName NVARCHAR(100)
)

CREATE TABLE HERO(
    HeroID int PRIMARY KEY,
    HeroName NVARCHAR(100),
    MinDiceValue int,
    MaxDiceValue int,
    InitialUses int,
    ImageFileName NVARCHAR(100)
)

CREATE TABLE VILLAIN(
    VillainID int PRIMARY KEY,
    VillainName NVARCHAR(100),
    VillainHealth int,
    ImageFileName NVARCHAR(100)
)

GO

INSERT INTO GAMERESULTS(GameResultsID, Created, WinnerName) Values
(1,'2021-10-04', 'Villains'),
(2,'2021-10-04', 'Villains'),
(3,'2021-10-04', 'Heroes'),
(4,'2021-10-04', 'Heroes'),
(5,'2021-10-04', 'Villains');

INSERT INTO HERO(HeroID, HeroName, MinDiceValue, MaxDiceValue, InitialUses, ImageFileName) VALUES
(1, 'Captain Swinburne',1,4,2, 'Captain Swinburne.png'),
(2, 'Rick',2,6,4, 'Rick.png');

INSERT INTO VILLAIN(VillainID, VillainName, VillainHealth, ImageFileName) VALUES
(1, 'ManagementMan',2,'ManagementMan.png'),
(2, 'RusselSprout',4,'RusselSprout.png'),
(3, 'TerroristTed',6,'TerroristTed.png');


select * from villain

