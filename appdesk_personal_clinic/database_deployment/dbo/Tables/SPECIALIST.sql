﻿CREATE TABLE [dbo].[SPECIALIST]
(
	[idSpecialist] INT NOT NULL PRIMARY KEY IDENTITY(10, 1), 
    [fullName] NVARCHAR(50) NULL, 
    [location] NVARCHAR(20) NULL
)
