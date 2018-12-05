CREATE TABLE [dbo].[PartnersOfDiffusion]
(
	[id]             INT NOT NULL PRIMARY KEY IDENTITY,
	[Name]           NVARCHAR (50) NOT NULL,
	[Username]       NVARCHAR (50),
	[Password]       NVARCHAR (200),
	[Confirmed]      bit NOT NULL,
	[Id_Company]     INT NOT NULL,
	[Id_LightUser]   INT NOT NULL,
	CONSTRAINT [FK_PartnersOfDiffusion_Company] FOREIGN KEY ([id_Company]) REFERENCES [dbo].Company(id),
	CONSTRAINT [FK_PartnersOfDiffusion_LightUser] FOREIGN KEY ([id_LightUser]) REFERENCES LightUser(id),
	CONSTRAINT [AK_PartnersOfDiffusion_LightUser] UNIQUE ([id_LightUser])
)