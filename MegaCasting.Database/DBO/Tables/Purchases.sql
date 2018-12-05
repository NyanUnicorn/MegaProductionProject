CREATE TABLE [dbo].[Purchases]
(
	[Id]               INT NOT NULL PRIMARY KEY IDENTITY,
	[Quantite]         INT NOT NULL,
	[ValidationDate]   DATETIME NOT NULL,
	[Cost]             DECIMAL(10,2) NOT NULL,
	[Id_PackCasting]   INT NOT NULL,
	CONSTRAINT [FK_Purchases_PackCasting] FOREIGN KEY ([id_PackCasting]) REFERENCES [dbo].[PackCasting]
)