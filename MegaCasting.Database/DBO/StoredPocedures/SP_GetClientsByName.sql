CREATE PROCEDURE [dbo].[SP_GetClientsByName]
	@param1 NVARCHAR(200)
AS
	SELECT [ClientCompany].[Name], [ClientCompany].[TelNumApplication], [ClientCompany].[TelNumContact], [ClientCompany].[StreetName], [ClientCompany].[CityName], [ClientCompany].[PostalCode], [ClientCompany].[TokenRestant] 
	FROM [ClientCompany]
	WHERE [ClientCompany].[Name] LIKE '%'+@param1+'%';
RETURN 0



	
