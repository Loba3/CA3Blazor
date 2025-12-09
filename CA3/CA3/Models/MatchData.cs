using System.Text.Json.Serialization;
using CA3.Models.CA3.Models;

namespace CA3.Models
{
    public class MatchData
    {
        public int matchID { get; set; }
        public DateTime matchDateTime { get; set; }
        public string? timeZoneID { get; set; }
        public int leagueId { get; set; }
        public string? leagueName { get; set; }
        public int leagueSeason { get; set; }
        public string? leagueShortcut { get; set; }
        public DateTime matchDateTimeUTC { get; set; }

        public Group? group { get; set; }

        [JsonPropertyName("team1")]
        public Team? Team1 { get; set; }

        [JsonPropertyName("team2")]
        public Team? Team2 { get; set; }

        public DateTime lastUpdateDateTime { get; set; }
        public bool matchIsFinished { get; set; }
        public List<MatchResult>? matchResults { get; set; }
        public List<Goal>? goals { get; set; }

        public Location? location { get; set; }
        public object? numberOfViewers { get; set; }
    }
}
