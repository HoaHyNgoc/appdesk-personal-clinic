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
