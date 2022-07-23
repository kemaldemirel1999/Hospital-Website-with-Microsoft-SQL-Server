CREATE TABLE [dbo].[Clinic]
(
	[HeadDoctorId] CHAR(10) NULL , 
    [Location] NVARCHAR(50) NOT NULL, 
    [Name] NVARCHAR(50) NOT NULL, 
    CONSTRAINT [PK_Clinic] PRIMARY KEY ([Name]), 
    CONSTRAINT [FK_Clinic_ToTable_Employee] FOREIGN KEY ([HeadDoctorId]) REFERENCES [Employee]([EmployeeId])
)
