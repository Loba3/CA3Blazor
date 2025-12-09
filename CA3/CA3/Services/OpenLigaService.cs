using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace CA3.Services
{
    public class OpenLigaService
    {
        private readonly HttpClient _http;

        public OpenLigaService(HttpClient http)
        {
            _http = http;
        }

        public async Task<object?> GetSeasonAsync(string league, int season)
        {
            string url = $"https://api.openligadb.de/getmatchdata/{league}/{season}";
            return await _http.GetFromJsonAsync<object>(url);
        }

        public async Task<object?> GetMatchdayAsync(string league, int season, int matchday)
        {
            string url = $"https://api.openligadb.de/getmatchdata/{league}/{season}/{matchday}";
            return await _http.GetFromJsonAsync<object>(url);
        }
    }
}
