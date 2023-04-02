namespace UniMix.Services.Spotify
{
    public partial class SpotifyService
    {
        private readonly HttpClient _httpClient;
        public SpotifyService(HttpClient httpClient)
        {
            _httpClient = httpClient;

            _httpClient.BaseAddress = new Uri("https://api.spotify.com/");
        }
    }
}
