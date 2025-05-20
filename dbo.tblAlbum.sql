CREATE TABLE [dbo].[tblAlbum] (
    [AlbumID]      INT           IDENTITY (1, 1) NOT NULL,
    [Title]        VARCHAR (50)  NULL,
    [Genre]        VARCHAR (50)  NOT NULL,
    [ReleaseDate] DATETIME      NOT NULL,
    [Edition]      VARCHAR (50)  NOT NULL,
    [Description]  VARCHAR (MAX) NULL,
    [ArtistID]     INT           NOT NULL,
    [Price]        MONEY         DEFAULT ((0)) NOT NULL,
    PRIMARY KEY CLUSTERED ([AlbumID] ASC)
);

