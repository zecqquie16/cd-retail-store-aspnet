CREATE PROCEDURE sproc_tblAlbum_Delete
	@AlbumID int 
	
AS
	DELETE FROM tblAlbum WHERE AlbumID=@AlbumID
RETURN 0
