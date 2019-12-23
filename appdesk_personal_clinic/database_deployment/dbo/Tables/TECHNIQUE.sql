CREATE TABLE [dbo].[TECHNIQUE]
(
	[idTechnique] INT NOT NULL PRIMARY KEY IDENTITY(4000, 1),
    [idDoctor] INT NOT NULL, 
    [price] MONEY NULL, 
    [idPatient] INT NOT NULL, 
    [dateTime] DATETIME NULL, 
    CONSTRAINT [FK_idDoctorTechnique_ToDOCTOR] FOREIGN KEY ([idDoctor]) REFERENCES [DOCTOR]([idDoctor]), 
    CONSTRAINT [FK_idPatientTechnique_ToPATIENT] FOREIGN KEY ([idPatient]) REFERENCES [PATIENT]([idPatient]) 
)
