CREATE TABLE [dbo].[TECHNIQUE]
(
	[idTechnique] INT NOT NULL PRIMARY KEY IDENTITY(4000, 1),
    [idDoctor] INT NOT NULL, 
    [price] MONEY NULL, 
    CONSTRAINT [FK_idDoctorTechnique_ToDOCTOR] FOREIGN KEY ([idDoctor]) REFERENCES [DOCTOR]([idDoctor]) 
)
