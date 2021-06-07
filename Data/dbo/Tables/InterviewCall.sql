CREATE TABLE [dbo].[InterviewCall]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [CallDate] DATETIME2 NOT NULL, 
    [ContactedPerson] NVARCHAR(50) NULL, 
    [PhoneNumber] NVARCHAR(12) NULL, 
    [Company] NVARCHAR(50) NOT NULL, 
    [Location] NVARCHAR(50) NOT NULL, 
    [IsShortListed] BIT NOT NULL DEFAULT 0, 
    [InterviewDate] DATETIME2 NULL, 
    [Remarks] NVARCHAR(MAX) NULL
)
