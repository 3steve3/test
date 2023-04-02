namespace UniMix.Services
{
    public interface ISearch
    {
        Task<Models.AppleMusic.GenericSearchModel?> GenericSearch(string Query);
        Task SearchSongs(string Query);
        Task SearchArtists(string Query);
        Task SearchAlbums(string Query);
        Task SearchPlaylists(string Query);
        Task SearchStations(string Query);
    }
}
