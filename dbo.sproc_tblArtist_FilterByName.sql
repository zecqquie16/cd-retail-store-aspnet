CREATE PROCEDURE sproc_tblArtist_FilterByName
	@Name varchar(50)
	
AS
	SELECT * FROM tblArtist WHERE Name LIKE @Name + '%';
RETURN 0
