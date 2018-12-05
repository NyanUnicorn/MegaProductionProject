CREATE PROCEDURE [dbo].[SP_GetCastingPacks]
AS
	SELECT [PackCasting].[Id], [PackCasting].[LabelFr], [PackCasting].[Quantity], [PackCasting].[Tarif] FROM [PackCasting]
RETURN 0
