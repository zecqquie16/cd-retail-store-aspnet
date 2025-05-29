CREATE PROCEDURE sproc_tblArtist_Delete
	@ArtistID int 
	
AS
	DELETE FROM tblArtist WHERE ArtistID=@ArtistID
RETURN 0