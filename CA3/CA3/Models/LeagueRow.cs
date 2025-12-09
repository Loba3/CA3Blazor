namespace CA3.Models
{
    public class LeagueRow
    {
        public string LeagueName { get; set; } = "";
        public string Shortcut { get; set; } = "";
        public int Season { get; set; }
        public int Matchday { get; set; }
        public string TimeUntil { get; set; } = "";
    }
}
