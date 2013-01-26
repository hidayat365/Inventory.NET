/****** Object:  Trigger [trg_UpdateInventories1]    Script Date: 05/02/2011 23:25:13 ******/
IF  EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N'[dbo].[trg_UpdateInventories1]'))
DROP TRIGGER [dbo].[trg_UpdateInventories1]
GO

/****** Object:  Trigger [dbo].[trg_UpdateInventories1]    Script Date: 05/02/2011 23:25:13 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author: Nur Hidayat
-- Create date: 2011-04-15
-- Description:	Update Item Inventories
-- =============================================
CREATE TRIGGER [dbo].[trg_UpdateInventories1]
   ON  [dbo].[OrderDetails] 
   AFTER INSERT
AS 
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	-- Insert statements for trigger here
	WITH t as (
		SELECT ItemID, WarehouseID
		, SUM(CASE 
			WHEN OrderType='IA' THEN Quantity  
			WHEN OrderType='RR' THEN Quantity  
			WHEN OrderType='DO' THEN -Quantity 
			ELSE 0 END
		) AS Quantity
		FROM Orders JOIN inserted ON Orders.ID = inserted.OrderID
		GROUP BY ItemID, WarehouseID
	)
	UPDATE ItemInventories
	SET Quantity = ItemInventories.Quantity + t.Quantity 
	FROM t
	WHERE ItemInventories.ItemID = t.ItemID
	AND ItemInventories.WarehouseID = t.WarehouseID
END


GO



/****** Object:  Trigger [trg_UpdateInventories2]    Script Date: 05/02/2011 23:25:46 ******/
IF  EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N'[dbo].[trg_UpdateInventories2]'))
DROP TRIGGER [dbo].[trg_UpdateInventories2]
GO

/****** Object:  Trigger [dbo].[trg_UpdateInventories2]    Script Date: 05/02/2011 23:25:46 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author: Nur Hidayat
-- Create date: 2011-04-15
-- Description:	Update Item Inventories
-- =============================================
CREATE TRIGGER [dbo].[trg_UpdateInventories2]
   ON  [dbo].[OrderDetails] 
   AFTER UPDATE
AS 
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	-- Update inventories
	WITH t as (
		SELECT ItemID, WarehouseID
		, SUM(CASE 
			WHEN OrderType='IA' THEN Quantity  
			WHEN OrderType='RR' THEN Quantity  
			WHEN OrderType='DO' THEN -Quantity 
			ELSE 0 END
		) AS Quantity
		FROM Orders JOIN inserted ON Orders.ID = inserted.OrderID
		GROUP BY ItemID, WarehouseID
	)
	UPDATE ItemInventories
	SET Quantity = ItemInventories.Quantity + t.Quantity 
	FROM t
	WHERE ItemInventories.ItemID = t.ItemID
	AND ItemInventories.WarehouseID = t.WarehouseID;
	-- Update inventories
	WITH t as (
		SELECT ItemID, WarehouseID
		, SUM(CASE 
			WHEN OrderType='IA' THEN Quantity  
			WHEN OrderType='RR' THEN Quantity  
			WHEN OrderType='DO' THEN -Quantity 
			ELSE 0 END
		) AS Quantity
		FROM Orders JOIN deleted ON Orders.ID = deleted.OrderID
		GROUP BY ItemID, WarehouseID
	)
	UPDATE ItemInventories
	SET Quantity = ItemInventories.Quantity - t.Quantity 
	FROM t
	WHERE ItemInventories.ItemID = t.ItemID
	AND ItemInventories.WarehouseID = t.WarehouseID;
END


GO

/****** Object:  Trigger [trg_UpdateInventories3]    Script Date: 05/02/2011 23:25:55 ******/
IF  EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N'[dbo].[trg_UpdateInventories3]'))
DROP TRIGGER [dbo].[trg_UpdateInventories3]
GO

/****** Object:  Trigger [dbo].[trg_UpdateInventories3]    Script Date: 05/02/2011 23:25:55 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author: Nur Hidayat
-- Create date: 2011-04-15
-- Description:	Update Item Inventories
-- =============================================
CREATE TRIGGER [dbo].[trg_UpdateInventories3]
   ON  [dbo].[OrderDetails] 
   AFTER DELETE
AS 
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	-- Update inventories
	WITH t as (
		SELECT ItemID, WarehouseID
		, SUM(CASE 
			WHEN OrderType='IA' THEN Quantity  
			WHEN OrderType='RR' THEN Quantity  
			WHEN OrderType='DO' THEN -Quantity 
			ELSE 0 END
		) AS Quantity
		FROM Orders JOIN deleted ON Orders.ID = deleted.OrderID
		GROUP BY ItemID, WarehouseID
	)
	UPDATE ItemInventories
	SET Quantity = ItemInventories.Quantity - t.Quantity 
	FROM t
	WHERE ItemInventories.ItemID = t.ItemID
	AND ItemInventories.WarehouseID = t.WarehouseID
END


GO

/****** Object:  Trigger [trg_NewItem]    Script Date: 05/02/2011 23:26:26 ******/
IF  EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N'[dbo].[trg_NewItem]'))
DROP TRIGGER [dbo].[trg_NewItem]
GO

/****** Object:  Trigger [dbo].[trg_NewItem]    Script Date: 05/02/2011 23:26:27 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author: Nur Hidayat (hidayat365@yahoo.com
-- Create date: 2011-04-16
-- Description:	Add entry to ItemInventories
-- =============================================
CREATE TRIGGER [dbo].[trg_NewItem] 
   ON  [dbo].[Items] 
   AFTER INSERT
AS 
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	-- Insert statements for trigger here
	INSERT INTO ItemInventories (ItemID,WarehouseID,Quantity)
	SELECT inserted.ID, Warehouses.ID, 0 FROM inserted, Warehouses;
END

GO

/****** Object:  Trigger [trg_NewWarehouse]    Script Date: 05/02/2011 23:28:23 ******/
IF  EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N'[dbo].[trg_NewWarehouse]'))
DROP TRIGGER [dbo].[trg_NewWarehouse]
GO

/****** Object:  Trigger [dbo].[trg_NewWarehouse]    Script Date: 05/02/2011 23:28:23 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author: Nur Hidayat (hidayat365@yahoo.com
-- Create date: 2011-04-16
-- Description:	Add entry to ItemInventories
-- =============================================
CREATE TRIGGER [dbo].[trg_NewWarehouse]
   ON  [dbo].[Warehouses] 
   AFTER INSERT
AS 
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	-- Insert statements for trigger here
	INSERT INTO ItemInventories (ItemID,WarehouseID,Quantity)
	SELECT Items.ID, inserted.ID, 0 FROM inserted, Items;
END

GO

