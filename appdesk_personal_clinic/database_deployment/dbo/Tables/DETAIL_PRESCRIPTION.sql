CREATE TABLE [dbo].[DETAIL_PRESCRIPTION]
(
	[idDetailPrescription] INT NOT NULL PRIMARY KEY IDENTITY(200, 1), 
    [idPrescription] INT NOT NULL, 
    [idMedicine] INT NOT NULL, 
    [number] INT NOT NULL, 
    [useHelp] NVARCHAR(50) NULL, 
    [price] MONEY NULL, 
    CONSTRAINT [FK_idPrescriptionDetailPre_ToPRESCRIPTION] FOREIGN KEY ([idPrescription]) REFERENCES PRESCRIPTION([idPrescription]), 
    CONSTRAINT [FK_idMedicineDetailPre_ToMEDICINE] FOREIGN KEY ([idMedicine]) REFERENCES [MEDICINE]([idMedicine])
)
