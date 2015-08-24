CREATE TABLE [dbo].[tblCar]
(
	[VehicleRegNo] VARCHAR(10) NOT NULL PRIMARY KEY, 
    [Make] VARCHAR(50) NULL, 
    [EngineSize] VARCHAR(10) NULL, 
    [DateRegistered] DATE NULL, 
    [RentalPerDay] DECIMAL(18, 2) NULL, 
    [Available] BIT NULL
)
