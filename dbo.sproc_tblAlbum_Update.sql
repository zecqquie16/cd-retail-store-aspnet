CREATE PROCEDURE sproc_tblAlbum_Update
    @AlbumID int,
    @Title varchar(50),
    @Genre varchar(50),
    @Description varchar(MAX),
    @Edition varchar(50),
    @ArtistID int,
    @ReleaseDate datetime,
    @Price money
AS
UPDATE tblAlbum
SET
    Title = @Title,
    Genre = @Genre,
    Description = @Description,
    Edition = @Edition,
    ArtistID = @ArtistID,
    ReleaseDate = @ReleaseDate,
    Price = @Price
WHERE AlbumID = @AlbumID

RETURN 0
