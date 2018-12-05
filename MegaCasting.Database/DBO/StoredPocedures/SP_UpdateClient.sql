CREATE PROCEDURE [dbo].[SP_UpdateClient]
	@clientId INT,
	@name NVARCHAR(200),
	@telNumCt NVARCHAR(11),
	@telNumApp NVARCHAR(11),
	@street NVARCHAR(200),
	@city NVARCHAR(200),
	@postalCode NVARCHAR(6),
	@tokensLeft INT,
	@packQt INT,
	@packCost DECIMAL(10,2),
	@packCastingId INT
AS
	IF NULLIF(@clientId, '') IS NULL
		BEGIN
			INSERT INTO [dbo].[ClientCompany]([Name], [TelNumContact], [TelNumApplication], [StreetName], [CityName], [PostalCode], [TokenRestant])
			VALUES(@name, @telNumCt, @telNumApp, @street, @city, @postalCode, @tokensLeft);
			SELECT @clientId = SCOPE_IDENTITY();
		END
	ELSE
		BEGIN
			UPDATE [dbo].[ClientCompany] 
			SET [Name] = @name,
			[TelNumContact] = @telNumCt,
			[TelNumApplication] = @telNumApp,
			[StreetName] = @street,
			[CityName] = @city,
			[PostalCode] = @postalCode,
			[TokenRestant] = @tokensLeft
			WHERE [ClientCompany].[Id] = @clientId;
		END
	IF NOT NULLIF(@packQt, 0) IS NULL
		BEGIN
			DECLARE @packId INT;
			INSERT INTO [dbo].[Purchases]([Quantite], [ValidationDate], [Cost], [Id_PackCasting])
			VALUES(@packQt, GETDATE(), @packCost, @packCastingId);
			SELECT @packId = SCOPE_IDENTITY();
			INSERT INTO [dbo].[ClientPurchase]([Id_ClientCompany], [ID_Purchases])
			VALUES(@clientId, @packId);
		END

RETURN 0