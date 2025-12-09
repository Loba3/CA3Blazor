using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using CA3.Models;

namespace CA3.Services
{
    public class OpenLigaService
    {
        private readonly HttpClient _http;

        public OpenLigaService(HttpClient http)
        {
            _http = http;
        }

        public async Task<List<Group>?> GetCurrentGroupAsync(string shortcut)
        {
            string url = $"https://api.openligadb.de/getcurrentgroup/{shortcut}";
            return await _http.GetFromJsonAsync<List<Group>>(url);
        }


        public async Task<List<MatchData>> GetMatchdayAsync(string league, int season, int matchday)
        {
            string url = $"https://api.openligadb.de/getmatchdata/{league}/{season}/{matchday}";

            var data = await _http.GetFromJsonAsync<List<MatchData>>(url);

            return data ?? new List<MatchData>(); // <-- prevents null crash
        }
        public async Task<List<LeagueInfo>> GetAvailableLeaguesAsync()
        {
            const string url = "https://api.openligadb.de/getavailableleagues";
            var data = await _http.GetFromJsonAsync<List<LeagueInfo>>(url);
            return data ?? new List<LeagueInfo>();
        }

    }
}
