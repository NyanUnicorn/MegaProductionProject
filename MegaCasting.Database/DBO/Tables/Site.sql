CREATE TABLE [dbo].[Site]
(
	[Id]           INT NOT NULL PRIMARY KEY IDENTITY,
	[Name]         NVARCHAR(200) NOT NULL,
	[Id_Company]   INT NOT NULL,
	CONSTRAINT [FK_Site_Company] FOREIGN KEY ([id_Company]) REFERENCES [dbo].[Company]
)