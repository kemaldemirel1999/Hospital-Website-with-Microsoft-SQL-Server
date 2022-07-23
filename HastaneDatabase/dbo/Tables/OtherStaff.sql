CREATE TABLE [dbo].[OtherStaff]
(
	[EmpId] CHAR(10) NOT NULL PRIMARY KEY, 
    CONSTRAINT [FK_OtherStaff_ToTable_Employee] FOREIGN KEY ([EmpId]) REFERENCES [Employee]([EmployeeId])
)
