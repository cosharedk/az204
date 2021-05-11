CREATE TABLE [dbo].[OrderHeader]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Customer] INT NOT NULL, 
    [Amount] NCHAR(10) NULL, 
    [Reference] VARCHAR(50) NULL, 
    CONSTRAINT [FK_OrderHeader_ToCustomer] FOREIGN KEY ([Customer]) REFERENCES [Customer]([Id])
)
