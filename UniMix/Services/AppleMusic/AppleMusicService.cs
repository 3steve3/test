using Microsoft.Extensions.Options;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace UniMix.Services.AppleMusic
{
    public partial class AppleMusicService
    {
        private readonly HttpClient _httpClient;
        readonly JsonSerializerOptions JsonOptions = new();
        
        public AppleMusicService(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _httpClient.BaseAddress = new Uri("https://api.music.apple.com/");

            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", AppleMusicDevKey.Key);

            JsonOptions.Converters.Add(new JsonStringEnumConverter());
        }
        public void AddUserToken(string token)
        {
            _httpClient.DefaultRequestHeaders.Add("Music-User-Token", token);
        }
    }
}
