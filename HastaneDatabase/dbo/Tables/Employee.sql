CREATE TABLE [dbo].[Employee]
(
	[EmployeeId] CHAR(10) NOT NULL PRIMARY KEY, 
    [FirstName] NVARCHAR(50) NOT NULL, 
    [Surname] NVARCHAR(50) NOT NULL, 
    [Phone] CHAR(10) NOT NULL, 
    [Gender] CHAR NOT NULL, 
    [Address] NVARCHAR(MAX) NOT NULL, 
    [Salary] NVARCHAR(50) NOT NULL
)
GO

