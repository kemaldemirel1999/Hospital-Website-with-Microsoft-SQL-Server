CREATE TABLE [dbo].[Nurse]
(
	[EmpId] CHAR(10) NOT NULL , 
    [Room_responsible] NVARCHAR(50) NOT NULL, 
    CONSTRAINT [FK_Nurse_ToTable_Employee] FOREIGN KEY ([EmpId]) REFERENCES [Employee]([EmployeeId]), 
    CONSTRAINT [FK_Nurse_ToTable_Room] FOREIGN KEY ([Room_responsible]) REFERENCES [Room]([RoomNo])
)
