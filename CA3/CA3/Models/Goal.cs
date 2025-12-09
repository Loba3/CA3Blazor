namespace CA3.Models
{
    public class Goal
    {
        public int goalID { get; set; }
        public int scoreTeam1 { get; set; }
        public int scoreTeam2 { get; set; }
        public int matchMinute { get; set; }
        public int goalGetterID { get; set; }
        public string? goalGetterName { get; set; }
        public bool isPenalty { get; set; }
        public bool isOwnGoal { get; set; }
        public bool isOvertime { get; set; }
        public string? comment { get; set; }
    }
}


