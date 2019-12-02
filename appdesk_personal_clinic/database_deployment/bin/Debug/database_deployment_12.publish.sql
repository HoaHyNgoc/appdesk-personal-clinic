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

INSERT INTO [dbo].[SPECIALIST] ([fullName], [location])
VALUES
('H(a)ematology','A01'),
('Immunology','A02'),
('Internal medicine','B01'),
('Traumatology','B02'),
('Surgery','C01');

INSERT INTO [dbo].[UNIT_MEDICINE] ([fullNameUnit]) 
VALUES 
('unit_01'),
('unit_02'),
('unit_03'),
('unit_04'),
('unit_05');

INSERT INTO [dbo].[PATIENT] ([idPassport], [fullName], [birthday], [healthStatus]) 
VALUES 
('17520000', 'Patient_01', '1998', 1),
('17520001', 'Patient_02', '1999', 1),
('17520002', 'Patient_03', '2000', 1),
('17520003', 'Patient_04', '1998', 1),
('17520004', 'Patient_05', '2000', 1);

INSERT INTO [dbo].[PHARMACIST] ([idPassport], [fullName]) 
VALUES 
('18520000', 'Pharmacist_01'),
('18520001', 'Pharmacist_02'),
('18520002', 'Pharmacist_03'),
('18520003', 'Pharmacist_04'),
('18520004', 'Pharmacist_05');

--INSERT INTO dbo.DOCTOR (idSpecialist, idPassport, fullName, isGeneral)
--VALUES
--(10, '16520001', 'Alex', 1),
--(10, '16520002', 'Meri', 1),
--(11, '16520003', 'Jack', 0),
--(12, '16520004', 'Kari', 0),
--(12, '16520005', 'Erik', 0);
GO

GO
PRINT N'Update complete.';


GO
