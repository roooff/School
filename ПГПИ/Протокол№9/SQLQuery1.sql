CREATE TABLE dbo.PurchaseOrderDetail 
( 
 PurchaseOrderID int NOT NULL 
 ,LineNumber smallint NOT NULL 
 ,ProductID int NULL 
 ,UnitPrice money NULL 
 ,OrderQty smallint NULL 
 ,ReceivedQty float NULL 
 ,RejectedQty float NULL 
 ,DueDate datetime NULL 
);