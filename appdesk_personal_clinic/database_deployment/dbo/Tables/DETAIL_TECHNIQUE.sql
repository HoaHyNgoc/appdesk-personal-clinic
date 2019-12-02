CREATE TABLE [dbo].[DETAIL_TECHNIQUE]
(
	[idDetailTechnique] INT NOT NULL PRIMARY KEY IDENTITY(3000, 1), 
    [idTechnique] INT NOT NULL, 
    [idDiagnostic] INT NOT NULL, 
    [result] NVARCHAR(50) NOT NULL, 
    [price] MONEY NOT NULL, 
    CONSTRAINT [FK_idTechniqueDetailTech_ToTECHNIQUE] FOREIGN KEY ([idTechnique]) REFERENCES [TECHNIQUE]([idTechnique]), 
    CONSTRAINT [FK_idDiagnosticDetailTech_ToDIAGNOSTIC] FOREIGN KEY ([idDiagnostic]) REFERENCES [DIAGNOSTIC]([idDiagnostic])
)
