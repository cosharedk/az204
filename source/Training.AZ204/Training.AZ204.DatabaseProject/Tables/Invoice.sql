CREATE TABLE [dbo].[Invoice]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [RelativeUrl] VARCHAR(MAX) NOT NULL, 
    [Amount] DECIMAL NOT NULL, 
    [Customer] INT NOT NULL, 
    CONSTRAINT [FK_Invoice_ToCustomer] FOREIGN KEY ([Customer]) REFERENCES [Customer]([Id])
)
