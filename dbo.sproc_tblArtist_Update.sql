CREATE PROCEDURE sproc_tblArtist_Update
    @ArtistID int,
    @Name varchar(50),
    @Genre varchar(50),
    @Biography varchar(MAX),
    @Nationality varchar(50),
	@Solo bit
    
AS
UPDATE tblArtist
SET
    Name = @Name,
    Genre = @Genre,
    Biography = @Biography,
    Nationality = @Nationality,
    Solo = @Solo
WHERE ArtistID = @ArtistID

RETURN 0