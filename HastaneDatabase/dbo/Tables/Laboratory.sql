CREATE TABLE [dbo].[Laboratory]
(
	[Room_no] NVARCHAR(50) NOT NULL, 
    [Supervisor_name] NVARCHAR(50) NULL, 
    CONSTRAINT [FK_Laboratory_ToTable_Room] FOREIGN KEY ([Room_no]) REFERENCES [Room]([RoomNo]) 
)
