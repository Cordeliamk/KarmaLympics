namespace KarmaLympics.Models {

    public class Quest {

        public int Id { get; set; } //PK
        public string Name { get; set; } = string.Empty;
        public bool HostQuest { get; set; }
        public int EventId { get; set; } //FK

        //Navigation Property

        public Event? Event { get; set; } = null;
        public ICollection<Challenge>? Challenges { get; set; } = null;

    }
}
