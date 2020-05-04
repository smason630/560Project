USE [master]; -- Your database here.

/*********************
 * Drop Tables
 *********************/

IF SCHEMA_ID(N'GamesLibrary') IS NULL
   EXEC(N'CREATE SCHEMA [GamesLibrary];');
GO

DROP TABLE IF EXISTS GamesLibrary.PublishedGameDeveloper;
DROP TABLE IF EXISTS GamesLibrary.PublishedGame;
DROP TABLE IF EXISTS GamesLibrary.Publisher;
DROP TABLE IF EXISTS GamesLibrary.Games;
DROP TABLE IF EXISTS GamesLibrary.Genre;
DROP TABLE IF EXISTS GamesLibrary.Console;
DROP TABLE IF EXISTS GamesLibrary.Publisher;
DROP TABLE IF EXISTS GamesLibrary.Developer;


GO

CREATE TABLE GamesLibrary.Publisher
(
    PublisherId INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    [Name] NVARCHAR(64) NOT NULL,
    Country NVARCHAR(64) NOT NULL
);

CREATE TABLE GamesLibrary.Developer
(
    DeveloperId INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    [Name] NVARCHAR(64) NOT NULL,
    Country NVARCHAR(64) NOT NULL 
);

CREATE TABLE GamesLibrary.Genre
(
    GenreId INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    [Name] NVARCHAR(64) NOT NULL,
);

CREATE TABLE GamesLibrary.Console
(
    ConsoleId INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    [Name] NVARCHAR(32) NOT NULL,
);

CREATE TABLE GamesLibrary.Games
(
    GameId INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    [Name] NVARCHAR(64) NOT NULL,
    GenreId INT NOT NULL FOREIGN KEY REFERENCES GamesLibrary.Genre(GenreId),
    ConsoleId INT NOT NULL FOREIGN KEY REFERENCES GamesLibrary.Console(ConsoleId),
    Rating INT NOT NULL
);

CREATE TABLE GamesLibrary.PublishedGame
(
    PublishedGameId Int NOT NULL IDENTITY(1,1) PRIMARY KEY,
    PublisherId INT NOT NULL FOREIGN KEY REFERENCES GamesLibrary.Publisher(PublisherId),
    GameId INT NOT NULL FOREIGN KEY REFERENCES GamesLibrary.Games(GameId),
    PublishDate Date NOT NULL
);

CREATE TABLE GamesLibrary.PublishedGameDeveloper
(
    DeveloperId INT NOT NULL PRIMARY KEY FOREIGN KEY REFERENCES GamesLibrary.Developer(DeveloperId),
    PublishedGameId INT NOT NULL FOREIGN KEY REFERENCES GamesLibrary.PublishedGame(PublishedGameId)
)