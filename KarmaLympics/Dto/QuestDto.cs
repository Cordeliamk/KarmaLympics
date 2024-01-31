namespace KarmaLympics.Dto {

    public class QuestDto {

        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public bool HostQuest { get; set; }
        public int EventId { get; set; }
    }
}
