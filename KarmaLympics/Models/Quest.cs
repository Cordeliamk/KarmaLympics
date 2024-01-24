namespace KarmaLympics.Models {

    public class Quest {

        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public bool HostQuest { get; set; }
        public int EventId { get; set; }

        //Navigation Property

        //public ICollection<Team> Teams { get; set; }
        public Event? Event { get; set; } = null;
        public ICollection<TeamQuest>? TeamQuests { get; set; } = null;
        public ICollection<Challenge>? Challenges { get; set; } = null;
    }
}
