using System.Text.Json;

namespace UniMix.Services.AppleMusic
{
    public partial class AppleMusicService : ISearch
    {
        public async Task<Models.AppleMusic.GenericSearchModel?> GenericSearch(string Query)
        {
            using var result = await _httpClient.GetAsync(new Uri($"/v1/catalog/us/search?types=albums,artists,playlists,songs,stations&term={System.Web.HttpUtility.UrlEncode(Query)}", UriKind.Relative), HttpCompletionOption.ResponseHeadersRead);
            result.EnsureSuccessStatusCode();
            var stream = await result.Content.ReadAsStreamAsync();

            return await JsonSerializer.DeserializeAsync<Models.AppleMusic.GenericSearchModel>(stream, JsonOptions);
        }

        public Task SearchAlbums(string Query)
        {
            throw new NotImplementedException();
        }

        public Task SearchArtists(string Query)
        {
            throw new NotImplementedException();
        }

        public Task SearchPlaylists(string Query)
        {
            throw new NotImplementedException();
        }

        public Task SearchSongs(string Query)
        {
            throw new NotImplementedException();
        }

        public Task SearchStations(string Query)
        {
            throw new NotImplementedException();
        }
    }
}
