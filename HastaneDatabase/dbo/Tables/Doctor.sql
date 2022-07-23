CREATE TABLE [dbo].[Doctor]
(
	[EmpId] CHAR(10) NOT NULL, 
    [Clinic_name] NVARCHAR(50) NOT NULL, 
    [Branch] NVARCHAR(50) NULL, 
    CONSTRAINT [FK_Doctor_ToTable_Employee] FOREIGN KEY ([EmpId]) REFERENCES [Employee]([EmployeeId]), 
    CONSTRAINT [FK_Doctor_ToTable_Doctor] FOREIGN KEY ([Clinic_name]) REFERENCES [Clinic]([Name]) 
)
