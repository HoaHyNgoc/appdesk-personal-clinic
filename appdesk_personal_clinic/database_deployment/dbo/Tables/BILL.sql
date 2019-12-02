CREATE TABLE [dbo].[BILL]
(
	[idBill] INT NOT NULL PRIMARY KEY IDENTITY(300, 1), 
    [idPrescription] INT NOT NULL, 
    [idTechnique] INT NOT NULL, 
    [idPharmacist] INT NOT NULL, 
    [valuePayBill] MONEY NULL, 
    [dateInit] DATETIME2 NULL, 
    CONSTRAINT [FK_idPrescriptionBill_ToPRESCRIPTION] FOREIGN KEY ([idPrescription]) REFERENCES [PRESCRIPTION]([idPrescription]), 
    CONSTRAINT [FK_idTechniqueBill_ToTECHNIQUE] FOREIGN KEY ([idTechnique]) REFERENCES [TECHNIQUE]([idTechnique]), 
    CONSTRAINT [FK_idPharmacist_ToPHARMACIST] FOREIGN KEY ([idPharmacist]) REFERENCES [PHARMACIST]([idPharmacist])
)
