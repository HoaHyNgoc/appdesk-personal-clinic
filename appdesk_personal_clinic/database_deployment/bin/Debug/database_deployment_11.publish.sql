﻿/*
Deployment script for DBPersonalClinic

This code was generated by a tool.
Changes to this file may cause incorrect behavior and will be lost if
the code is regenerated.
*/

GO
SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER ON;

SET NUMERIC_ROUNDABORT OFF;


GO
:setvar DatabaseName "DBPersonalClinic"
:setvar DefaultFilePrefix "DBPersonalClinic"
:setvar DefaultDataPath "C:\Users\PC\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\MSSQLLocalDB"
:setvar DefaultLogPath "C:\Users\PC\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\MSSQLLocalDB"

GO
:on error exit
GO
/*
Detect SQLCMD mode and disable script execution if SQLCMD mode is not supported.
To re-enable the script after enabling SQLCMD mode, execute the following:
SET NOEXEC OFF; 
*/
:setvar __IsSqlCmdEnabled "True"
GO
IF N'$(__IsSqlCmdEnabled)' NOT LIKE N'True'
    BEGIN
        PRINT N'SQLCMD mode must be enabled to successfully execute this script.';
        SET NOEXEC ON;
    END


GO
USE [$(DatabaseName)];


GO
PRINT N'Rename refactoring operation with key d79bfbb0-d396-47cd-a9a4-d57a559a6e29 is skipped, element [dbo].[DETAIL_TECHNIQUE].[idDiagnostic] (SqlSimpleColumn) will not be renamed to idTechnique';


GO
PRINT N'Rename refactoring operation with key e72a401b-32a9-40db-9a99-9292b5da54e1 is skipped, element [dbo].[TECHNIQUE].[Id] (SqlSimpleColumn) will not be renamed to idTechnique';


GO
PRINT N'Rename refactoring operation with key fb492018-ea4f-4c4e-831b-86c17fd4fe76 is skipped, element [dbo].[DETAIL_TECHNIQUE].[Id] (SqlSimpleColumn) will not be renamed to idDetailTechnique';


GO
PRINT N'Rename refactoring operation with key c0246859-f1d1-4a93-9c41-a22c3f51158e is skipped, element [dbo].[DETAIL_TECHNIQUE].[result] (SqlSimpleColumn) will not be renamed to idDiagnostic';


GO
PRINT N'Rename refactoring operation with key d1b9f329-e3cf-460b-99c6-5e859427617b is skipped, element [dbo].[DIAGNOSTIC].[Id] (SqlSimpleColumn) will not be renamed to idDiagnostic';


GO
PRINT N'Rename refactoring operation with key e757b780-1831-4dec-ab67-f4c181dd3bd4 is skipped, element [dbo].[MEDICAL_RECORD].[Id] (SqlSimpleColumn) will not be renamed to idMedicalRecord';


GO
PRINT N'Rename refactoring operation with key c1fb4c2d-3222-4b08-9533-4071f514df82 is skipped, element [dbo].[PHARMACIST].[Id] (SqlSimpleColumn) will not be renamed to idPharmacist';


GO
PRINT N'Rename refactoring operation with key 6acb8ba0-ea27-433b-9da9-5e8cd8f3d632 is skipped, element [dbo].[UNIT_MEDICINE].[Id] (SqlSimpleColumn) will not be renamed to idUnitMedicine';


GO
PRINT N'Rename refactoring operation with key c0068b01-64a2-468c-8fd6-86e03942ceaf is skipped, element [dbo].[MEDICINE].[Id] (SqlSimpleColumn) will not be renamed to idMedicine';


GO
PRINT N'Rename refactoring operation with key 1703f883-a70b-46fd-ad33-3ddc041a5dd9 is skipped, element [dbo].[PRESCRIPTION].[Id] (SqlSimpleColumn) will not be renamed to idPrescription';


GO
PRINT N'Rename refactoring operation with key e28f9e3b-863a-43b6-aa13-64da89abd0e7 is skipped, element [dbo].[DETAIL_PRESCRIPTION].[Id] (SqlSimpleColumn) will not be renamed to idDetailPrescription';


GO
PRINT N'Rename refactoring operation with key cfa7479f-6144-4a32-b90a-9d7c10de6421 is skipped, element [dbo].[BILL].[Id] (SqlSimpleColumn) will not be renamed to idBill';


GO
PRINT N'Creating [dbo].[BILL]...';


GO
CREATE TABLE [dbo].[BILL] (
    [idBill]         INT           IDENTITY (300, 1) NOT NULL,
    [idPrescription] INT           NOT NULL,
    [idTechnique]    INT           NOT NULL,
    [idPharmacist]   INT           NOT NULL,
    [valuePayBill]   MONEY         NULL,
    [dateInit]       DATETIME2 (7) NULL,
    PRIMARY KEY CLUSTERED ([idBill] ASC)
);


GO
PRINT N'Creating [dbo].[DETAIL_PRESCRIPTION]...';


GO
CREATE TABLE [dbo].[DETAIL_PRESCRIPTION] (
    [idDetailPrescription] INT           IDENTITY (200, 1) NOT NULL,
    [idPrescription]       INT           NOT NULL,
    [idMedicine]           INT           NOT NULL,
    [number]               INT           NOT NULL,
    [useHelp]              NVARCHAR (50) NULL,
    [price]                MONEY         NULL,
    PRIMARY KEY CLUSTERED ([idDetailPrescription] ASC)
);


GO
PRINT N'Creating [dbo].[DETAIL_TECHNIQUE]...';


GO
CREATE TABLE [dbo].[DETAIL_TECHNIQUE] (
    [idDetailTechnique] INT           IDENTITY (3000, 1) NOT NULL,
    [idTechnique]       INT           NOT NULL,
    [idDiagnostic]      INT           NOT NULL,
    [result]            NVARCHAR (50) NOT NULL,
    [price]             MONEY         NOT NULL,
    PRIMARY KEY CLUSTERED ([idDetailTechnique] ASC)
);


GO
PRINT N'Creating [dbo].[DIAGNOSTIC]...';


GO
CREATE TABLE [dbo].[DIAGNOSTIC] (
    [idDiagnostic] INT           IDENTITY (5000, 1) NOT NULL,
    [idSpecialist] INT           NOT NULL,
    [numberRoom]   NVARCHAR (10) NULL,
    [fullName]     NVARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([idDiagnostic] ASC)
);


GO
PRINT N'Creating [dbo].[MEDICAL_RECORD]...';


GO
CREATE TABLE [dbo].[MEDICAL_RECORD] (
    [idMedicalRecord] INT           IDENTITY (6000, 1) NOT NULL,
    [idPatient]       INT           NOT NULL,
    [idDoctor]        INT           NOT NULL,
    [history]         NVARCHAR (50) NOT NULL,
    [dateInitMedical] DATETIME2 (7) NULL,
    [request]         NVARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([idMedicalRecord] ASC)
);


GO
PRINT N'Creating [dbo].[MEDICINE]...';


GO
CREATE TABLE [dbo].[MEDICINE] (
    [idMedicine]     INT           IDENTITY (9000, 1) NOT NULL,
    [idUnitMedicine] INT           NOT NULL,
    [fullName]       NVARCHAR (50) NOT NULL,
    [symbol]         NVARCHAR (20) NULL,
    [ingredient]     NVARCHAR (50) NOT NULL,
    [priceUnit]      MONEY         NOT NULL,
    PRIMARY KEY CLUSTERED ([idMedicine] ASC)
);


GO
PRINT N'Creating [dbo].[PHARMACIST]...';


GO
CREATE TABLE [dbo].[PHARMACIST] (
    [idPharmacist] INT           IDENTITY (7000, 1) NOT NULL,
    [idPassport]   NVARCHAR (20) NOT NULL,
    [fullName]     NVARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([idPharmacist] ASC)
);


GO
PRINT N'Creating [dbo].[PRESCRIPTION]...';


GO
CREATE TABLE [dbo].[PRESCRIPTION] (
    [idPrescription]    INT           IDENTITY (100, 1) NOT NULL,
    [idPatient]         INT           NOT NULL,
    [conclusionMedical] NVARCHAR (50) NOT NULL,
    [price]             MONEY         NOT NULL,
    PRIMARY KEY CLUSTERED ([idPrescription] ASC)
);


GO
PRINT N'Creating [dbo].[TECHNIQUE]...';


GO
CREATE TABLE [dbo].[TECHNIQUE] (
    [idTechnique] INT   IDENTITY (4000, 1) NOT NULL,
    [idDoctor]    INT   NOT NULL,
    [price]       MONEY NULL,
    PRIMARY KEY CLUSTERED ([idTechnique] ASC)
);


GO
PRINT N'Creating [dbo].[UNIT_MEDICINE]...';


GO
CREATE TABLE [dbo].[UNIT_MEDICINE] (
    [idUnitMedicine] INT           IDENTITY (8000, 1) NOT NULL,
    [fullNameUnit]   NVARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([idUnitMedicine] ASC)
);


GO
PRINT N'Creating [dbo].[FK_idPrescriptionBill_ToPRESCRIPTION]...';


GO
ALTER TABLE [dbo].[BILL] WITH NOCHECK
    ADD CONSTRAINT [FK_idPrescriptionBill_ToPRESCRIPTION] FOREIGN KEY ([idPrescription]) REFERENCES [dbo].[PRESCRIPTION] ([idPrescription]);


GO
PRINT N'Creating [dbo].[FK_idTechniqueBill_ToTECHNIQUE]...';


GO
ALTER TABLE [dbo].[BILL] WITH NOCHECK
    ADD CONSTRAINT [FK_idTechniqueBill_ToTECHNIQUE] FOREIGN KEY ([idTechnique]) REFERENCES [dbo].[TECHNIQUE] ([idTechnique]);


GO
PRINT N'Creating [dbo].[FK_idPharmacist_ToPHARMACIST]...';


GO
ALTER TABLE [dbo].[BILL] WITH NOCHECK
    ADD CONSTRAINT [FK_idPharmacist_ToPHARMACIST] FOREIGN KEY ([idPharmacist]) REFERENCES [dbo].[PHARMACIST] ([idPharmacist]);


GO
PRINT N'Creating [dbo].[FK_idPrescriptionDetailPre_ToPRESCRIPTION]...';


GO
ALTER TABLE [dbo].[DETAIL_PRESCRIPTION] WITH NOCHECK
    ADD CONSTRAINT [FK_idPrescriptionDetailPre_ToPRESCRIPTION] FOREIGN KEY ([idPrescription]) REFERENCES [dbo].[PRESCRIPTION] ([idPrescription]);


GO
PRINT N'Creating [dbo].[FK_idMedicineDetailPre_ToMEDICINE]...';


GO
ALTER TABLE [dbo].[DETAIL_PRESCRIPTION] WITH NOCHECK
    ADD CONSTRAINT [FK_idMedicineDetailPre_ToMEDICINE] FOREIGN KEY ([idMedicine]) REFERENCES [dbo].[MEDICINE] ([idMedicine]);


GO
PRINT N'Creating [dbo].[FK_idTechniqueDetailTech_ToTECHNIQUE]...';


GO
ALTER TABLE [dbo].[DETAIL_TECHNIQUE] WITH NOCHECK
    ADD CONSTRAINT [FK_idTechniqueDetailTech_ToTECHNIQUE] FOREIGN KEY ([idTechnique]) REFERENCES [dbo].[TECHNIQUE] ([idTechnique]);


GO
PRINT N'Creating [dbo].[FK_idDiagnosticDetailTech_ToDIAGNOSTIC]...';


GO
ALTER TABLE [dbo].[DETAIL_TECHNIQUE] WITH NOCHECK
    ADD CONSTRAINT [FK_idDiagnosticDetailTech_ToDIAGNOSTIC] FOREIGN KEY ([idDiagnostic]) REFERENCES [dbo].[DIAGNOSTIC] ([idDiagnostic]);


GO
PRINT N'Creating [dbo].[FK_idSpecialistDiagnostic_ToSPECIALIST]...';


GO
ALTER TABLE [dbo].[DIAGNOSTIC] WITH NOCHECK
    ADD CONSTRAINT [FK_idSpecialistDiagnostic_ToSPECIALIST] FOREIGN KEY ([idSpecialist]) REFERENCES [dbo].[SPECIALIST] ([idSpecialist]);


GO
PRINT N'Creating [dbo].[FK_idPatientMedicalRecord_ToPATIENT]...';


GO
ALTER TABLE [dbo].[MEDICAL_RECORD] WITH NOCHECK
    ADD CONSTRAINT [FK_idPatientMedicalRecord_ToPATIENT] FOREIGN KEY ([idPatient]) REFERENCES [dbo].[PATIENT] ([idPatient]);


GO
PRINT N'Creating [dbo].[FK_idDoctorMedicalRecord_ToDOCTOR]...';


GO
ALTER TABLE [dbo].[MEDICAL_RECORD] WITH NOCHECK
    ADD CONSTRAINT [FK_idDoctorMedicalRecord_ToDOCTOR] FOREIGN KEY ([idDoctor]) REFERENCES [dbo].[DOCTOR] ([idDoctor]);


GO
PRINT N'Creating [dbo].[FK_idUnitMedicineMedicine_ToUNIT_MEDICINE]...';


GO
ALTER TABLE [dbo].[MEDICINE] WITH NOCHECK
    ADD CONSTRAINT [FK_idUnitMedicineMedicine_ToUNIT_MEDICINE] FOREIGN KEY ([idUnitMedicine]) REFERENCES [dbo].[UNIT_MEDICINE] ([idUnitMedicine]);


GO
PRINT N'Creating [dbo].[FK_idPatientPrescription_ToPATIENT]...';


GO
ALTER TABLE [dbo].[PRESCRIPTION] WITH NOCHECK
    ADD CONSTRAINT [FK_idPatientPrescription_ToPATIENT] FOREIGN KEY ([idPatient]) REFERENCES [dbo].[PATIENT] ([idPatient]);


GO
PRINT N'Creating [dbo].[FK_idDoctorTechnique_ToDOCTOR]...';


GO
ALTER TABLE [dbo].[TECHNIQUE] WITH NOCHECK
    ADD CONSTRAINT [FK_idDoctorTechnique_ToDOCTOR] FOREIGN KEY ([idDoctor]) REFERENCES [dbo].[DOCTOR] ([idDoctor]);


GO
-- Refactoring step to update target server with deployed transaction logs

IF OBJECT_ID(N'dbo.__RefactorLog') IS NULL
BEGIN
    CREATE TABLE [dbo].[__RefactorLog] (OperationKey UNIQUEIDENTIFIER NOT NULL PRIMARY KEY)
    EXEC sp_addextendedproperty N'microsoft_database_tools_support', N'refactoring log', N'schema', N'dbo', N'table', N'__RefactorLog'
END
GO
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = 'e72a401b-32a9-40db-9a99-9292b5da54e1')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('e72a401b-32a9-40db-9a99-9292b5da54e1')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = 'fb492018-ea4f-4c4e-831b-86c17fd4fe76')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('fb492018-ea4f-4c4e-831b-86c17fd4fe76')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = 'd79bfbb0-d396-47cd-a9a4-d57a559a6e29')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('d79bfbb0-d396-47cd-a9a4-d57a559a6e29')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = 'c0246859-f1d1-4a93-9c41-a22c3f51158e')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('c0246859-f1d1-4a93-9c41-a22c3f51158e')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = 'd1b9f329-e3cf-460b-99c6-5e859427617b')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('d1b9f329-e3cf-460b-99c6-5e859427617b')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = 'e757b780-1831-4dec-ab67-f4c181dd3bd4')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('e757b780-1831-4dec-ab67-f4c181dd3bd4')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = 'c1fb4c2d-3222-4b08-9533-4071f514df82')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('c1fb4c2d-3222-4b08-9533-4071f514df82')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = '6acb8ba0-ea27-433b-9da9-5e8cd8f3d632')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('6acb8ba0-ea27-433b-9da9-5e8cd8f3d632')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = 'c0068b01-64a2-468c-8fd6-86e03942ceaf')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('c0068b01-64a2-468c-8fd6-86e03942ceaf')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = '1703f883-a70b-46fd-ad33-3ddc041a5dd9')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('1703f883-a70b-46fd-ad33-3ddc041a5dd9')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = 'e28f9e3b-863a-43b6-aa13-64da89abd0e7')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('e28f9e3b-863a-43b6-aa13-64da89abd0e7')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = 'cfa7479f-6144-4a32-b90a-9d7c10de6421')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('cfa7479f-6144-4a32-b90a-9d7c10de6421')

GO

GO
/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/

--INSERT INTO dbo.SPECIALIST (fullName, location)
--VALUES
--('Medical_01','A01'),
--('Medical_02','A02'),
--('Medical_03','A03');

--INSERT INTO dbo.DOCTOR (idSpecialist, idPassport, fullName, isGeneral)
--VALUES
--(10, '16520001', 'Alex', 1),
--(10, '16520002', 'Meri', 1),
--(11, '16520003', 'Jack', 0),
--(12, '16520004', 'Kari', 0),
--(12, '16520005', 'Erik', 0);
GO

GO
PRINT N'Checking existing data against newly created constraints';


GO
USE [$(DatabaseName)];


GO
ALTER TABLE [dbo].[BILL] WITH CHECK CHECK CONSTRAINT [FK_idPrescriptionBill_ToPRESCRIPTION];

ALTER TABLE [dbo].[BILL] WITH CHECK CHECK CONSTRAINT [FK_idTechniqueBill_ToTECHNIQUE];

ALTER TABLE [dbo].[BILL] WITH CHECK CHECK CONSTRAINT [FK_idPharmacist_ToPHARMACIST];

ALTER TABLE [dbo].[DETAIL_PRESCRIPTION] WITH CHECK CHECK CONSTRAINT [FK_idPrescriptionDetailPre_ToPRESCRIPTION];

ALTER TABLE [dbo].[DETAIL_PRESCRIPTION] WITH CHECK CHECK CONSTRAINT [FK_idMedicineDetailPre_ToMEDICINE];

ALTER TABLE [dbo].[DETAIL_TECHNIQUE] WITH CHECK CHECK CONSTRAINT [FK_idTechniqueDetailTech_ToTECHNIQUE];

ALTER TABLE [dbo].[DETAIL_TECHNIQUE] WITH CHECK CHECK CONSTRAINT [FK_idDiagnosticDetailTech_ToDIAGNOSTIC];

ALTER TABLE [dbo].[DIAGNOSTIC] WITH CHECK CHECK CONSTRAINT [FK_idSpecialistDiagnostic_ToSPECIALIST];

ALTER TABLE [dbo].[MEDICAL_RECORD] WITH CHECK CHECK CONSTRAINT [FK_idPatientMedicalRecord_ToPATIENT];

ALTER TABLE [dbo].[MEDICAL_RECORD] WITH CHECK CHECK CONSTRAINT [FK_idDoctorMedicalRecord_ToDOCTOR];

ALTER TABLE [dbo].[MEDICINE] WITH CHECK CHECK CONSTRAINT [FK_idUnitMedicineMedicine_ToUNIT_MEDICINE];

ALTER TABLE [dbo].[PRESCRIPTION] WITH CHECK CHECK CONSTRAINT [FK_idPatientPrescription_ToPATIENT];

ALTER TABLE [dbo].[TECHNIQUE] WITH CHECK CHECK CONSTRAINT [FK_idDoctorTechnique_ToDOCTOR];


GO
PRINT N'Update complete.';


GO
