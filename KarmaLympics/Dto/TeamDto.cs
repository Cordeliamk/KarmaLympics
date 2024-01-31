namespace KarmaLympics.Dto {

    public class TeamDto {

        public int Id { get; set; }
        public string TeamName { get; set; } = string.Empty;
        public string TeamUrl { get; set; } = string.Empty;
        public int EventId { get; set; }
    }
}
