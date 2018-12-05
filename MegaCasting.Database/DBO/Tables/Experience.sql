CREATE TABLE [dbo].[Experience]
(
	[Id]            INT NOT NULL PRIMARY KEY IDENTITY,
	[Description]   NVARCHAR(500) NOT NULL,
	[Company]       NVARCHAR(200) NOT NULL,
	[Place]         NVARCHAR(200),
	[Id_Artist]     INT NOT NULL,
	CONSTRAINT [FKExperience_Artist] FOREIGN KEY ([id_Artist]) REFERENCES [dbo].[Artist]
)