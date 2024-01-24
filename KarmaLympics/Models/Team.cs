namespace KarmaLympics.Models {


    public class Team {

        public int Id { get; set; }
        public string TeamName { get; set; } = string.Empty;
        public string TeamUrl { get; set; } = string.Empty;
        public int EventId { get; set; }
        // Navigation Property

        public Event Event { get; set; }
        //public Quest Quest { get; set; }
        public ICollection<TeamQuest>? TeamQuests { get; set; } = null;
    }
}
