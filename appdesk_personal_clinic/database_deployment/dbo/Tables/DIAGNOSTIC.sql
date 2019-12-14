CREATE TABLE [dbo].[DIAGNOSTIC]
(
	[idDiagnostic] INT NOT NULL PRIMARY KEY IDENTITY(5000, 1), 
    [idSpecialist] INT NOT NULL, 
    [numberRoom] NVARCHAR(10) NULL, 
    [fullName] NVARCHAR(50) NULL, 
    [price] MONEY NULL, 
    CONSTRAINT [FK_idSpecialistDiagnostic_ToSPECIALIST] FOREIGN KEY ([idSpecialist]) REFERENCES [SPECIALIST]([idSpecialist])
)
