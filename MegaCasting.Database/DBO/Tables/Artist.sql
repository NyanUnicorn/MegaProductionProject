CREATE TABLE [dbo].[Artist]
(
	[Id]             INT NOT NULL PRIMARY KEY IDENTITY,
	[Id_LightUser]   INT NOT NULL,
	CONSTRAINT [FK_Artist_LightUser] FOREIGN KEY ([id_LightUser]) REFERENCES [dbo].[LightUser],
	CONSTRAINT [AK_Artist_LightUser] UNIQUE ([id_LightUser])
)