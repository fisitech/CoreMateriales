-- Examples for queries that exercise different SQL objects implemented by this assembly

-----------------------------------------------------------------------------------------
-- Stored procedure
-----------------------------------------------------------------------------------------
-- exec StoredProcedureName


-----------------------------------------------------------------------------------------
-- User defined function
-----------------------------------------------------------------------------------------


DECLARE @FILE AS varbinary(max)
SET @FILE = (SELECT  BulkColumn FROM OPENROWSET(BULK N'C:\Temp\MaquinariaEquipo.csv', SINGLE_BLOB) rs)
--MaquinariaEquipo,@file,'MaquinariaEquipo','123'
SELECT dbo.RunPackage('MaquinariaEquipo.csv',@FILE,'MaquinariaEquipo','123')
--SELECT dbo.RunPackage('materiales.csv',@FILE,'Materiales','123')