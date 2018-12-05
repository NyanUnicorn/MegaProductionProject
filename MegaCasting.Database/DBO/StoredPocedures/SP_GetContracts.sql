CREATE PROCEDURE [dbo].[SP_GetContracts]
AS
	SELECT [Id], [LabelFr], [LabelShortFr] FROM [ContractType]
RETURN 0
