CREATE TABLE [dbo].[MEDICAL_RECORD]
(
	[idMedicalRecord] INT NOT NULL PRIMARY KEY IDENTITY(6000, 1), 
    [idPatient] INT NOT NULL, 
    [idDoctor] INT NOT NULL, 
    [history] NVARCHAR(50) NOT NULL, 
    [dateInitMedical] DATETIME2 NULL, 
    [request] NVARCHAR(50) NULL, 
    CONSTRAINT [FK_idPatientMedicalRecord_ToPATIENT] FOREIGN KEY ([idPatient]) REFERENCES [PATIENT]([idPatient]), 
    CONSTRAINT [FK_idDoctorMedicalRecord_ToDOCTOR] FOREIGN KEY ([idDoctor]) REFERENCES [DOCTOR]([idDoctor])
)
