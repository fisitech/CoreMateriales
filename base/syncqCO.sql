USE [Core_v2]
GO

/****** Object:  StoredProcedure [dbo].[MaterialesSyncOC]    Script Date: 10/30/2012 15:45:29 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO



-- =============================================
-- Author:		Erik Carrillo
-- Create date: 15/07/2012
-- Description:	Sincroniza las ordenes de compra del archivo de excel con la tabla MaterialesOC
-- =============================================
CREATE PROCEDURE [dbo].[MaterialesSyncOC]
	@NoCliente Int
AS
BEGIN
	SET NOCOUNT ON;

    DECLARE @MaterialesOC TABLE(
		TableName varchar(100),
		[Id] [int] NOT NULL,
		[ClienteId] [int] NOT NULL,
		[RenglonId] [int] NOT NULL,
		[NumeroParte] [varchar](50) NULL,
		[Descripcion] [varchar](200) NULL,
		[Cantidad] [numeric](18, 4) NOT NULL,
		[PqOrd] [numeric](18, 4) NULL,
		[PqRec] [numeric](18, 4) NULL,
		[Precio] [numeric](18, 4) NULL,
		[ProveedorID] [varchar](150) NULL,
		[Descripcion_P] [varchar](200) NULL,		
		[UnidadMedida] [varchar](10) NULL,
	/*	[FacturaProveedor] [varchar](45) NULL,*/
		[Pais] [varchar](10) NULL,
		[Planta] [varchar](10) NULL,	
		[Moneda] [varchar](10) NULL,
		[ProgramaId] [varchar](50) NULL,
		[DrawingId] [varchar](80) NULL,
		[NombreProveedor] [varchar](250) NULL,
		[Text1] [varchar](50) NULL)
		
	----IF EXISTS (SELECT * FROM tempdb..sysobjects WHERE name like '#MaterialesOC%' AND xtype = 'U')
	----BEGIN
	----	DROP TABLE #MaterialesOC
	----END
		
	-- Seleccionar solo los	registros que coinciden con los del archivo de excel para compararlos y modificar los que sean diferentes
	SELECT 
		MaterialesOC.Id, MaterialesOC.ClienteId, MaterialesOC.RenglonId, MaterialesOC.NumeroParte, MaterialesOC.Descripcion,
		MaterialesOC.CantidadOriginal AS Cantidad, MaterialesOC.PqOrd,MaterialesOC.PqRec, MaterialesOC.Precio, MaterialesOC.ProveedorID, MaterialesOC.Descripcion_P,
		MaterialesOC.UnidadMedida, /*MaterialesOC.FacturaProveedor, */MaterialesOC.Pais, MaterialesOC.Planta, MaterialesOC.Moneda,
		MaterialesOC.ProgramaId, MaterialesOC.DrawingId, MaterialesOC.NombreProveedor, MaterialesOC.Text1
	INTO 
		#MaterialesOC 	
	FROM 
		MaterialesOC INNER JOIN 
		MaterialesExcelOC ON 
			MaterialesOC.Id = MaterialesExcelOC.Id AND 
			MaterialesOC.ClienteId = MaterialesExcelOC.ClienteId AND 
			MaterialesOC.RenglonId = MaterialesExcelOC.RenglonId
	WHERE
		MaterialesOC.ClienteId = @NoCliente


	--Insertar en la variable tipo tabla los registros que son diferentes y que no existen en la tabla actual
	INSERT INTO @MaterialesOC	
		SELECT 
			MIN(TableName) as TableName, Id,ClienteId,RenglonId,NumeroParte,Descripcion,Cantidad,PqOrd,PqRec,
			Precio,ProveedorID,Descripcion_P,UnidadMedida,/*FacturaProveedor,*/Pais,Planta,Moneda,ProgramaId,DrawingId,
			NombreProveedor, Text1
		FROM
		(
		  SELECT 'Produccion' as TableName, Id,ClienteId,RenglonId,NumeroParte,Descripcion,Cantidad,PqOrd,PqRec,
			Precio,ProveedorID,Descripcion_P,UnidadMedida,/*FacturaProveedor,*/Pais,Planta,Moneda,ProgramaId,DrawingId,
			NombreProveedor, Text1
		  FROM #MaterialesOC 
		  UNION ALL
		  SELECT 'Excel' as TableName, Id,ClienteId,RenglonId,NumeroParte,Descripcion,Cantidad,PqOrd,PqRec,
			Precio,ProveedorID,Descripcion_P,UnidadMedida,/*FacturaProveedor,*/Pais,Planta,Moneda,ProgramaId,DrawingId,
			NombreProveedor, Text1
		  FROM 
			MaterialesExcelOC
		  WHERE 
			ClienteId = @NoCliente
		) tmp
		GROUP BY Id,ClienteId,RenglonId,NumeroParte,Descripcion,Cantidad,PqOrd,PqRec,
			Precio,ProveedorID,Descripcion_P,UnidadMedida,/*FacturaProveedor,*/Pais,Planta,Moneda,ProgramaId,DrawingId,
			NombreProveedor, Text1
		HAVING COUNT(*) = 1	

	----REGISTROS PARA ACTUALIZAR
	DECLARE @Id Int
	DECLARE @ClienteId Int
	DECLARE @RenglonId Int

	DECLARE c_actualizar CURSOR FOR 
		SELECT Id,ClienteId,RenglonId FROM @MaterialesOC group by Id,ClienteId,RenglonId HAVING COUNT(*) = 2
		
	OPEN c_actualizar

	FETCH NEXT FROM c_actualizar INTO @Id,@ClienteId,@RenglonId

	WHILE @@FETCH_STATUS = 0
	BEGIN
		--Guardar registro del renglon original en la tabla log antes de actualizar para tener trazabilidad de los cambios efectuados
		INSERT INTO MaterialesLogOC 
				(Id, ClienteId, RenglonId, Fecha, NumeroParte, Descripcion, Cantidad,
				PqOrd,PqRec, Precio, Proveedor, Descripcion_P, UnidadMedida, FacturaProveedor, Pais,
				Planta, Moneda, ProgramaId, DrawingId, UsuarioId)
			SELECT
				Prod.Id, Prod.ClienteId, Prod.RenglonId, GETDATE() AS Fecha, Prod.NumeroParte, Prod.Descripcion, Prod.CantidadOriginal,
				Prod.PqOrd,Prod.PqRec, Prod.Precio, Prod.ProveedorID, Prod.Descripcion_P, Prod.UnidadMedida, Prod.FacturaProveedor, Prod.Pais,
				Prod.Planta, Prod.Moneda, Prod.ProgramaId, Prod.DrawingId, 1 AS UsuarioID
			FROM 
				MaterialesOC Prod 
			WHERE
				Prod.Id = @Id AND Prod.ClienteId = @ClienteId AND Prod.RenglonId = @RenglonId	
		
		--Actualiza registro actual con los nuevos valores recopilados del archivo de excel
		UPDATE
			Prod
		SET 
			Prod.Id = Excel.Id,
			Prod.ClienteId = Excel.ClienteId,
			Prod.RenglonId = Excel.RenglonId,
			Prod.NumeroParte = Excel.NumeroParte,
			Prod.Descripcion = Excel.Descripcion,
			Prod.CantidadOriginal = Excel.Cantidad,
			Prod.PqOrd = Excel.PqOrd,
			Prod.PqRec = Excel.PqRec,
			Prod.Precio = Excel.Precio,
			Prod.ProveedorID = Excel.ProveedorID,
			Prod.Descripcion_P = Excel.Descripcion_P,
			Prod.UnidadMedida = Excel.UnidadMedida,
			/*Prod.FacturaProveedor = Excel.FacturaProveedor,*/
			Prod.Pais = Excel.Pais,
			Prod.Planta = Excel.Planta,
			Prod.Moneda = Excel.Moneda,
			Prod.ProgramaId = Excel.ProgramaId,
			Prod.DrawingId = Excel.DrawingId,
			Prod.NombreProveedor = Excel.NombreProveedor, 
			Prod.Text1 = Excel.Text1
		FROM 
			MaterialesOC Prod INNER JOIN
			MaterialesExcelOC Excel ON  Prod.Id = Excel.Id AND Prod.ClienteId = Excel.ClienteId AND Prod.RenglonId = Excel.RenglonId
		WHERE
			Prod.Id = @Id AND Prod.ClienteId = @ClienteId AND Prod.RenglonId = @RenglonId	
			
		FETCH NEXT FROM c_actualizar INTO @Id,@ClienteId,@RenglonId
	END

	CLOSE c_actualizar

	DEALLOCATE c_actualizar


	--REGISTROS PARA INSERTAR NUEVOS

	DECLARE c_insertar CURSOR FOR 
		SELECT Id,	ClienteId,	RenglonId FROM @MaterialesOC GROUP BY Id,	ClienteId,	RenglonId HAVING COUNT(*) = 1
		
	OPEN c_insertar

	FETCH NEXT FROM c_insertar INTO @Id,@ClienteId,@RenglonId

	WHILE @@FETCH_STATUS = 0
	BEGIN
			
		INSERT INTO MaterialesOC 
				(Id, ClienteId, RenglonId, NumeroParte, Descripcion, CantidadOriginal, PqOrd,PqRec, Precio,
				ProveedorID,	Descripcion_P,	UnidadMedida,	FacturaProveedor,	Pais,	Planta,	Moneda,
				ProgramaId,	DrawingId, NombreProveedor, Text1, FechaRecibo)
			SELECT 
				Id,	ClienteId,	RenglonId,	NumeroParte,	Descripcion,	Cantidad,	PqOrd,PqRec,	Precio,
				ProveedorID,	Descripcion_P,	UnidadMedida,	FacturaProveedor,	Pais,	Planta,	Moneda,
				ProgramaId,	DrawingId, NombreProveedor, Text1, GETDATE() AS FechaRecibo
			FROM 
				MaterialesExcelOC 
			WHERE 
				Id = @Id AND ClienteId = @ClienteId AND	RenglonId = @RenglonId
			
		FETCH NEXT FROM c_insertar INTO @Id,@ClienteId,@RenglonId
	END

	CLOSE c_insertar

	DEALLOCATE c_insertar
	
	RETURN 0;
END



GO

