CREATE TABLE [dbo].[Orders]
(
	[orderID] INT NOT NULL PRIMARY KEY IDENTITY, 
    [orderDate] DATETIME NULL, 
    [orderAmount] INT NULL, 
    [paymentType] CHAR(10) NULL, 
    [customerID] INT NULL, 
    CONSTRAINT [FK_Orders_ToTable] FOREIGN KEY (customerID) REFERENCES Customers([CustomerID])
)
