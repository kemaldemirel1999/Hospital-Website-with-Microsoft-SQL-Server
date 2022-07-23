CREATE TABLE [dbo].[Laborant]
(
	[EmpId] CHAR(10) NOT NULL, 
    [Lab_no] NVARCHAR(50) NOT NULL, 
    CONSTRAINT [FK_Laborant_ToTable_Employee] FOREIGN KEY ([EmpId]) REFERENCES [Employee]([EmployeeId]), 
    CONSTRAINT [FK_Laborant_ToTable_Laboratory] FOREIGN KEY ([Lab_no]) REFERENCES [Room]([RoomNo]) 
)
