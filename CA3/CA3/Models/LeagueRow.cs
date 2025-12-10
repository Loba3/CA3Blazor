namespace CA3.Models
{
    public class LeagueRow
    {
        public int TeamId { get; set; }
        public string TeamName { get; set; } = string.Empty;

        public int Matches { get; set; }
        public int Won { get; set; }
        public int Draw { get; set; }
        public int Lost { get; set; }

        public int Goals { get; set; }
        public int OpponentGoals { get; set; }
        public int GoalDiff { get; set; }
        public int Points { get; set; }
    }
}
