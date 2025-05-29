CREATE PROCEDURE sproc_tblArtist_FilterByArtistID
	@ArtistID int 
	
AS
	 SELECT * FROM tblArtist
    WHERE ArtistID = @ArtistID;

    RETURN 0;

