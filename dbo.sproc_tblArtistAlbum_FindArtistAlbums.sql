CREATE PROCEDURE sproc_tblArtistAlbum_FindArtistAlbums
	@ArtistID Int
AS
BEGIN
	SELECT * FROM tblAlbum WHERE @ArtistID = ArtistID
END;