-- Examples for queries that exercise different SQL objects implemented by this assembly

-----------------------------------------------------------------------------------------
-- Stored procedure
-----------------------------------------------------------------------------------------
-- exec StoredProcedureName


-----------------------------------------------------------------------------------------
-- User defined function
-----------------------------------------------------------------------------------------


DECLARE @FILE AS varbinary(max)
SET @FILE = (SELECT  BulkColumn FROM OPENROWSET(BULK N'C:\RAWPO.CSV', SINGLE_BLOB) rs)
SELECT dbo.RunPackage('materiales.csv',@FILE,'Materiales','123')