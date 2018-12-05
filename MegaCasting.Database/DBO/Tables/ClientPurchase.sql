CREATE TABLE [dbo].[ClientPurchase]
(
	[Id_ClientCompany]	INT NOT NULL,
	[ID_Purchases]		INT NOT NULL,
	CONSTRAINT [PK_ClientPurchase] PRIMARY KEY ([Id_ClientCompany],[Id_Purchases]),
	CONSTRAINT [FK_ClientPurchases_ClientCompany] FOREIGN KEY ([Id_ClientCompany]) REFERENCES [dbo].[ClientCompany],
	CONSTRAINT [FK_ClientPurchases_Purchases] FOREIGN KEY ([Id_Purchases]) REFERENCES [dbo].[Purchases]
)
