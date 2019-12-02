CREATE TABLE [dbo].[MEDICINE]
(
	[idMedicine] INT NOT NULL PRIMARY KEY IDENTITY(9000, 1), 
    [idUnitMedicine] INT NOT NULL, 
    [fullName] NVARCHAR(50) NOT NULL, 
    [symbol] NVARCHAR(20) NULL, 
    [ingredient] NVARCHAR(50) NOT NULL, 
    [priceUnit] MONEY NOT NULL, 
    CONSTRAINT [FK_idUnitMedicineMedicine_ToUNIT_MEDICINE] FOREIGN KEY ([idUnitMedicine]) REFERENCES [UNIT_MEDICINE]([idUnitMedicine])
)
