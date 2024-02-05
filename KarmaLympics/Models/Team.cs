namespace KarmaLympics.Models {


    public class Team {

        public int Id { get; set; } //PK
        public string TeamName { get; set; } = string.Empty;
        public string TeamUrl { get; set; } = string.Empty;
        public int EventId { get; set; } //FK

        // Navigation Property

        public Event? Event { get; set; }
        public Quest? Quest { get; set; }

    }
}
