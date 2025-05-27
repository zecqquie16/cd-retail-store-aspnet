USE [p2855274]
GO

DECLARE	@return_value Int

EXEC	@return_value = [dbo].[sproc_Table_Costumer_SelectAll]

SELECT	@return_value as 'Return Value'

GO
