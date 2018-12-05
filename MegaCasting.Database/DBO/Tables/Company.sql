CREATE TABLE [dbo].[Company]
(
	[Id]            INT NOT NULL PRIMARY KEY IDENTITY,
	[Name]          NVARCHAR(200) NOT NULL,
	[Telephone]     NVARCHAR(11) NOT NULL,
	[StreetName]    NVARCHAR(200) NOT NULL,
	[CityName]		NVARCHAR(200) NOT NULL,
	[PostalCode]	NVARCHAR(6) NOT NULL,
)