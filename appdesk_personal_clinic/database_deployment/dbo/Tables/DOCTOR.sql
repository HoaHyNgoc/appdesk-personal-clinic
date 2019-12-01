CREATE TABLE [dbo].[DOCTOR]
(
	[idDoctor] INT NOT NULL PRIMARY KEY IDENTITY(200, 1), 
    [idSpecialist] INT NOT NULL, 
    [idPassport] NVARCHAR(20) NOT NULL, 
    [fullName] NVARCHAR(50) NULL, 
    [isGeneral] INT NULL, 
    CONSTRAINT [FK_idSpecialistDoctor_ToSPECIALIST] FOREIGN KEY ([idSpecialist]) REFERENCES [SPECIALIST]([idSpecialist])
)
