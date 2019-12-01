CREATE TABLE [dbo].[PATIENT]
(
	[idPatient] INT NOT NULL PRIMARY KEY IDENTITY(100, 1), 
    [idPassport] NVARCHAR(20) NOT NULL, 
    [fullName] NVARCHAR(50) NULL, 
    [birthday] NVARCHAR(20) NULL, 
    [healthStatus] INT NULL
)
