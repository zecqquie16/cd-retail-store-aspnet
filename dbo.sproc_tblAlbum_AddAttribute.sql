CREATE PROCEDURE sproc_tblAlbum_AddAttribute
	
AS 
	ALTER TABLE [dbo].[tblAlbum]
ADD [Cover] VARCHAR(255) NOT NULL DEFAULT 'StockOnTheRacksLogo.png';

RETURN 0
