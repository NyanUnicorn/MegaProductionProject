CREATE TABLE [dbo].[ClientCompany]
(
	[Id]					INT NOT NULL PRIMARY KEY IDENTITY,
	[Name]					NVARCHAR(200) NOT NULL,
	[TelNumContact]			NVARCHAR(11) NOT NULL,
	[TelNumApplication]		NVARCHAR(11),
	[StreetName]        	NVARCHAR(200) NOT NULL,
	[CityName]				NVARCHAR(200) NOT NULL,
	[PostalCode]			NVARCHAR(6) NOT NULL,
	[TokenRestant]			INT NOT NULL
)