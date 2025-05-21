CREATE PROCEDURE sproc_tblAlbum_FilterByTitle
	@Title varchar(50)
	
AS
	SELECT * FROM tblAlbum WHERE Title LIKE @Title + '%';
RETURN 0
