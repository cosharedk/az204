CREATE TABLE [dbo].[OrderDetails]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Description] VARCHAR(50) NOT NULL, 
    [PricePerUnit] NCHAR(10) NOT NULL, 
    [NumberOfUnits] INT NOT NULL, 
    [OrderHeader] INT NOT NULL, 
    CONSTRAINT [FK_OrderDetails_ToÓrderHeader] FOREIGN KEY ([OrderHeader]) REFERENCES [OrderHeader]([Id])
)
