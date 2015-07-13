CREATE TABLE [dbo].[Customers]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [firstName] CHAR(10) NOT NULL, 
    [lastName] CHAR(10) NOT NULL, 
    [address] VARCHAR(MAX) NULL, 
    [city] CHAR(10) NULL, 
    [county] CHAR(10) NULL, 
    [creditLimit] REAL NULL, 
    [customerSince] DATETIME NULL
)
