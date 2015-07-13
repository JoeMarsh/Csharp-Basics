CREATE TABLE [dbo].[Orders] (
    [orderID]     INT       IDENTITY (1, 1) NOT NULL,
    [orderDate]   DATETIME  NULL,
    [orderAmount] INT       NULL,
    [paymentType] CHAR (10) NULL,
    [customerID]  INT       NULL,
    PRIMARY KEY CLUSTERED ([orderID] ASC),
    CONSTRAINT [FK_Orders_ToTable] FOREIGN KEY ([customerID]) REFERENCES [dbo].[Customers] ([CustomerID])
);

