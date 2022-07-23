CREATE TABLE [dbo].[Manager]
(
	[EmpId] CHAR(10) NOT NULL, 
    CONSTRAINT [FK_Manager_ToTable_Employee] FOREIGN KEY ([EmpId]) REFERENCES [Employee]([EmployeeId]) 
)
