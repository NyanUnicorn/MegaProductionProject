CREATE TABLE [dbo].[ContractType]
(
	[Id]             INT NOT NULL PRIMARY KEY IDENTITY,
	[LabelFr]        NVARCHAR(200) NOT NULL,
	[LabelShortFr]   NVARCHAR(50) NOT NULL
)