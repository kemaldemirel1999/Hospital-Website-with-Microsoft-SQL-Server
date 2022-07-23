CREATE TABLE [dbo].[Prescription]
(
	[Pssn] CHAR(10) NOT NULL , 
    [EmpId] CHAR(10) NOT NULL, 
    [Date] DATE NOT NULL, 
    [Drug_name] NVARCHAR(50) NOT NULL, 
    [Given_date] DATE NOT NULL, 
    CONSTRAINT [FK_Prescription_ToTable_Patient] FOREIGN KEY ([Pssn]) REFERENCES [Patient]([Ssn]), 
    CONSTRAINT [FK_Prescription_ToTable_Employee] FOREIGN KEY ([EmpId]) REFERENCES [Employee]([EmployeeId])
)
