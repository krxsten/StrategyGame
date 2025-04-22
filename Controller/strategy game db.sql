CREATE DATABASE[Strategy_Game]
CREATE TABLE[Players]
(
[Id] INT PRIMARY KEY IDENTITY(1,1),
[Username] NVARCHAR(100),
[Email] NVARCHAR(100),
[CreatedAt] DATE
)
CREATE TABLE[Factions]
(
[Id] INT PRIMARY KEY IDENTITY(1,1),
[Name] NVARCHAR(100),
[Description] NVARCHAR(100),
)
CREATE TABLE[PlayerFactions]
(
[Id] INT PRIMARY KEY IDENTITY(1,1),
[PlayerId] INT FOREIGN KEY REFERENCES[Players]([Id]),
[FactionId] INT FOREIGN KEY REFERENCES[Factions]([Id]),
[StartDate] DATE
)
CREATE TABLE[Buildings]
(
[Id] INT PRIMARY KEY IDENTITY(1,1),
[Name] NVARCHAR(100),
[Description] NVARCHAR(100),
[BuildTime] DATE,
[FactionId] INT FOREIGN KEY REFERENCES[Factions]([Id]),
)
CREATE TABLE[PlayerBuildings]
(
[Id] INT PRIMARY KEY IDENTITY(1,1),
[PlayerId] INT FOREIGN KEY REFERENCES[Players]([Id]),
[BuildingId] INT FOREIGN KEY REFERENCES[Buildings]([Id]),
[Level] INT,
[BuiltAt] DATE
)
CREATE TABLE[Units]
(
[Id] INT PRIMARY KEY IDENTITY(1,1),
[Name] NVARCHAR(100),
[AttackPower] INT,
[DefensePower] INT,
[TrainingTime] DATE,
[FactionId] INT FOREIGN KEY REFERENCES[Factions]([Id]),
)
CREATE TABLE[PlayerUnits]
(
[Id] INT PRIMARY KEY IDENTITY(1,1),
[PlayerId] INT FOREIGN KEY REFERENCES[Players]([Id]),
[UnitId ] INT FOREIGN KEY REFERENCES[Units]([Id]),
[Quantity] INT
)
CREATE TABLE[Resources]
(
[Id] INT PRIMARY KEY IDENTITY(1,1),
[Name] NVARCHAR(100),
[Description] NVARCHAR(100),
)
CREATE TABLE[PlayerResources]
(
[Id] INT PRIMARY KEY IDENTITY(1,1),
[PlayerId] INT FOREIGN KEY REFERENCES[Players]([Id]),
[ResourceId] INT FOREIGN KEY REFERENCES[Resources]([Id]),
[Amount] INT
)
CREATE TABLE[Battles]
(
[Id] INT PRIMARY KEY IDENTITY(1,1),
[AttackerId] INT FOREIGN KEY REFERENCES[Players]([Id]),
[DefenderId ] INT FOREIGN KEY REFERENCES[Players]([Id]),
[StartedAt] DATE,
[EndedAt] DATE
)
CREATE TABLE[BattleUnits]
(
[Id] INT PRIMARY KEY IDENTITY(1,1),
[BattleId] INT FOREIGN KEY REFERENCES[Battles]([Id]),
[UnitId] INT FOREIGN KEY REFERENCES[Units]([Id]),
[PlayerId] INT FOREIGN KEY REFERENCES[Players]([Id]),
[Quantity] INT
)
CREATE TABLE[Maps]
(
[Id] INT PRIMARY KEY IDENTITY(1,1),
[Name] NVARCHAR(100),
[SizeX] INT,
[SizeY] INT,
[Description] NVARCHAR(100),
)
CREATE TABLE[PlayerLocations]
(
[Id] INT PRIMARY KEY IDENTITY(1,1),
[PlayerId] INT FOREIGN KEY REFERENCES[Players]([Id]),
[MapId] INT FOREIGN KEY REFERENCES[Maps]([Id]),
[X] INT,
[Y]INT
)
CREATE TABLE[Technologies]
(
[Id] INT PRIMARY KEY IDENTITY(1,1),
[Name] NVARCHAR(100),
[Description] NVARCHAR(100),
[ResearchTime] DATE
)
CREATE TABLE[PlayerTechnologies]
(
[Id] INT PRIMARY KEY IDENTITY(1,1),
[PlayerId] INT FOREIGN KEY REFERENCES[Players]([Id]),
[TechnologyId] INT FOREIGN KEY REFERENCES[Technologies]([Id]),
[IsResearched] NVARCHAR(100),
[ResearchedAt] DATE
)

INSERT INTO Factions (Name, Description) VALUES ('Humans', 'Balanced race with strong economy.');
INSERT INTO Factions (Name, Description) VALUES ('Orcs', 'Strong melee units, weak defenses.');

INSERT INTO Buildings (Name, Description, BuildTime, FactionId) 
VALUES ('Barracks', 'Trains infantry.', '2024-04-04', 1);
INSERT INTO Buildings (Name, Description, BuildTime, FactionId) 
VALUES ('Farm', 'Produces food.', '2024-08-08', 1);

INSERT INTO Units (Name, AttackPower, DefensePower, TrainingTime, FactionId) 
VALUES ('Swordsman', 10, 5, '2024-05-02', 1);
INSERT INTO Units (Name, AttackPower, DefensePower, TrainingTime, FactionId) 
VALUES ('Archer', 7, 3, '2024-09-03', 1);

INSERT INTO Resources (Name, Description) 
VALUES ('Gold', 'Used for building and training.');
INSERT INTO Resources (Name, Description) 
VALUES ('Food', 'Required for units to survive.');

INSERT INTO Technologies (Name, Description, ResearchTime) 
VALUES ('Advanced Metallurgy', 'Increases attack by 10%', '2024-06-04');
INSERT INTO Technologies (Name, Description, ResearchTime) 
VALUES ('Efficient Farming', 'Increases food production by 20%', '2024-04-06');

INSERT INTO Maps (Name, SizeX, SizeY, Description) 
VALUES ('Valley of Kings', 100, 100, 'A balanced map with hills and forests.');
