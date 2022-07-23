CREATE TABLE [dbo].[PatientRoom]
(
	[Room_no] NVARCHAR(50) NOT NULL, 
    [Pssn] CHAR(10) NULL, 
    [Capacity] NVARCHAR(50) NOT NULL, 
    CONSTRAINT [FK_PatientRoom_ToTable_Room] FOREIGN KEY ([Room_no]) REFERENCES [Room]([RoomNo]), 
    CONSTRAINT [FK_PatientRoom_ToTable_Patient] FOREIGN KEY ([Pssn]) REFERENCES [Patient]([Ssn]) 
)
