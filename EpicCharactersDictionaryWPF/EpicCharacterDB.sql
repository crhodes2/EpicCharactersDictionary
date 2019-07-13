USE master
GO

IF DB_ID('EpicCharacterDB') IS NOT NULL
DROP DATABASE EpicCharacterDB;
GO

CREATE DATABASE EpicCharacterDB
GO

USE EpicCharacterDB
GO

CREATE TABLE StoryModel
(
	StoryID int PRIMARY KEY CLUSTERED(StoryID ASC) NOT NULL,
	StoryTitle varchar(255) NOT NULL,
	StoryGenre varchar(255) NOT NULL,
	AuthorName varchar(255) NOT NULL,
	[Year] varchar(255) NOT NULL,
	StoryBio varchar(255)
)

CREATE TABLE CharacterModel
(
	CharacterID int PRIMARY KEY CLUSTERED(CharacterID ASC) NOT NULL,
	FirstName varchar(255) NOT NULL,
	LastName varchar(255),
	Age int,
	Gender char NOT NULL,
	Alignment varchar(255) NOT NULL,
	Nationality varchar(255),
	Bio varchar(255),
	PhysicalFeatures varchar(255),
	StoryID int FOREIGN KEY REFERENCES StoryModel(StoryID)
)


--STORY
INSERT INTO StoryModel VALUES(1,'HARRINGTONS','Family, Comedy','Chris Rhodes','2019', '');
INSERT INTO StoryModel VALUES(2,'SUPER SMASH BROS. HD - WORLD OF LIGHT','Action, Adventure','Chris Rhodes','2019', '');
INSERT INTO StoryModel VALUES(3,'CASEY TRESOR FAIRY TALES ODYSSEY - THE BOOK OF WONDERS','Fantasy, Adventure','Chris Rhodes','2019', '');
INSERT INTO StoryModel VALUES(4,'TALES OF FIRE EMBLEM HEROES','Fantasy','Chris Rhodes','2019', '');
INSERT INTO StoryModel VALUES(5,'TIMELESS HEROES','Adventure','Chris Rhodes','2019', '');

--CHARACTER
INSERT INTO CharacterModel VALUES(001,'Aaron','Harrington','18','M','Hero','','','', 1);
INSERT INTO CharacterModel VALUES(002,'Londres','Harrington','18','F','Hero','','','', 1);
INSERT INTO CharacterModel VALUES(003,'Troy','Harrington','16','M','Hero','','','', 1);
INSERT INTO CharacterModel VALUES(004,'Samantha','Harrington','17','F','Hero','','','', 1);
INSERT INTO CharacterModel VALUES(005,'Paris','Harrington','11','F','Hero','','','', 1);

INSERT INTO CharacterModel VALUES(006,'Jacen','Dim','22','M','Hero','','','', 2);
INSERT INTO CharacterModel VALUES(007,'Hunter-Lumiere','Starcrown','22','M','Hero','','','', 2);
INSERT INTO CharacterModel VALUES(008,'Christian','Chevalier','23','M','Neutral','','','', 2);
INSERT INTO CharacterModel VALUES(009,'Galeem','Starcrown','22','M','Villain','','','', 2);

INSERT INTO CharacterModel VALUES(010,'Casey','Tresor','16','M','Hero','','','', 3);
INSERT INTO CharacterModel VALUES(011,'Sofie','Charming','9','F','Hero','','','', 3);
INSERT INTO CharacterModel VALUES(012,'Victor','Tresor','32','M','Hero','','','', 3);

INSERT INTO CharacterModel VALUES(013,'Cameron','Banks','17','M','Hero','','','', 4);
INSERT INTO CharacterModel VALUES(014,'Haley','White','17','F','Hero','','','', 4);

INSERT INTO CharacterModel VALUES(015,'Chromium','Spellwood','25','M','Hero','','','', 5);


--TEST
SELECT *
FROM StoryModel s

SELECT *
FROM [CharacterModel] c

SELECT *
FROM [CharacterModel]
WHERE Alignment = 'Villain'

SELECT *
FROM [CharacterModel]
WHERE [CharacterModel].StoryID = 1