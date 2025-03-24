CREATE DATABASE Part1DB;
GO

USE Part1DB;
GO

CREATE TABLE StringProcessing (
    Id INT NOT NULL PRIMARY KEY,
    InputS NVARCHAR(255) NOT NULL,
    InputN INT NOT NULL,
    Time DATETIME DEFAULT GETDATE()
);
GO

CREATE TABLE StringRecentlyDelete (
    Id INT NOT NULL PRIMARY KEY,
    InputS NVARCHAR(255) NOT NULL,
    InputN INT NOT NULL,
    Time DATETIME DEFAULT GETDATE()
);
GO

INSERT INTO StringProcessing (Id, InputS, InputN, Time) VALUES
(1, 'Hello World', 5, '2024-03-21 10:00:00'),
(2, 'C# WinForms', 10, '2024-03-21 10:05:00'),
(3, 'Entity Framework', 7, '2024-03-21 10:10:00');
GO

INSERT INTO StringRecentlyDelete (Id, InputS, InputN, Time) VALUES
(4, 'Deleted String 1', 3, '2024-03-21 09:50:00'),
(5, 'Deleted String 2', 8, '2024-03-21 09:55:00');
GO