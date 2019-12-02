CREATE TABLE [dbo].[PRESCRIPTION]
(
	[idPrescription] INT NOT NULL PRIMARY KEY IDENTITY(100, 1), 
    [idPatient] INT NOT NULL, 
    [conclusionMedical] NVARCHAR(50) NOT NULL, 
    [price] MONEY NOT NULL, 
    CONSTRAINT [FK_idPatientPrescription_ToPATIENT] FOREIGN KEY ([idPatient]) REFERENCES [PATIENT]([idPatient])
)
