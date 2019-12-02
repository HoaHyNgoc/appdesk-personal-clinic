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

--INSERT INTO [dbo].[SPECIALIST] ([fullName], [location])
--VALUES
--('H(a)ematology','A01'),
--('Immunology','A02'),
--('Internal medicine','B01'),
--('Traumatology','B02'),
--('Surgery','C01');

--INSERT INTO [dbo].[UNIT_MEDICINE] ([fullNameUnit]) 
--VALUES 
--('unit_01'),
--('unit_02'),
--('unit_03'),
--('unit_04'),
--('unit_05');

--INSERT INTO [dbo].[PATIENT] ([idPassport], [fullName], [birthday], [healthStatus]) 
--VALUES 
--('17520000', 'Patient_01', '1998', 1),
--('17520001', 'Patient_02', '1999', 1),
--('17520002', 'Patient_03', '2000', 1),
--('17520003', 'Patient_04', '1998', 1),
--('17520004', 'Patient_05', '2000', 1);

--INSERT INTO [dbo].[PHARMACIST] ([idPassport], [fullName]) 
--VALUES 
--('18520000', 'Pharmacist_01'),
--('18520001', 'Pharmacist_02'),
--('18520002', 'Pharmacist_03'),
--('18520003', 'Pharmacist_04'),
--('18520004', 'Pharmacist_05');

/*-----------------------------------------------------------*/

--INSERT INTO dbo.DOCTOR (idSpecialist, idPassport, fullName, isGeneral)
--VALUES
--(2016, '16520000', 'Alex', 1),
--(2016, '16520001', 'Meri', 1),
--(2018, '16520002', 'Jack', 0),
--(2018, '16520003', 'Kari', 0),
--(2019, '16520004', 'Erik', 0);

--INSERT INTO [dbo].[DIAGNOSTIC] ([idSpecialist], [numberRoom], [fullName]) 
--VALUES 
--(2016, 'P100', 'Diagnostic_01'),
--(2016, 'P101', 'Diagnostic_02'),
--(2018, 'P102', 'Diagnostic_03'),
--(2018, 'P103', 'Diagnostic_04'),
--(2016, 'P104', 'Diagnostic_05');

--INSERT INTO [dbo].[MEDICINE] ([idUnitMedicine], [fullName], [symbol], [ingredient], [priceUnit]) 
--VALUES 
--(8000, 'Medicine_01', 'M01', 'ingredient_01', 10),
--(8000, 'Medicine_02', 'M02', 'ingredient_02', 20),
--(8001, 'Medicine_03', 'M03', 'ingredient_03', 30),
--(8002, 'Medicine_01', 'M04', 'ingredient_04', 40),
--(8002, 'Medicine_01', 'M05', 'ingredient_05', 10);