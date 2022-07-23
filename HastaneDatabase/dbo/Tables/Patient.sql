CREATE TABLE [dbo].[Patient]
(
	[Ssn] CHAR(10) NOT NULL PRIMARY KEY, 
    [FirstName] NVARCHAR(50) NOT NULL, 
    [Surname] NVARCHAR(50) NOT NULL, 
    [Phone] CHAR(10) NOT NULL, 
    [Birthdate] DATE NOT NULL, 
    [Gender] CHAR NOT NULL, 
    [Address] NVARCHAR(MAX) NOT NULL 
)
