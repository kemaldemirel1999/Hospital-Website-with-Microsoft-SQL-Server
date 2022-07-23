CREATE TABLE [dbo].[Appointment]
(
	[DoctorId] CHAR(10) NOT NULL , 
    [Date] DATE NOT NULL, 
    [ClinicName] NVARCHAR(50) NOT NULL, 
    [Pssn] CHAR(10) NOT NULL, 
    CONSTRAINT [FK_Appointment_ToTable_Patient] FOREIGN KEY ([Pssn]) REFERENCES [Patient]([Ssn]), 
    CONSTRAINT [FK_Appointment_ToTable_Employee] FOREIGN KEY ([DoctorId]) REFERENCES [Employee]([EmployeeId]), 
    CONSTRAINT [FK_Appointment_ToTable_Clinic] FOREIGN KEY ([ClinicName]) REFERENCES [Clinic]([Name])
)
