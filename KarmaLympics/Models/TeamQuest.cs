namespace KarmaLympics.Models {

    public class TeamQuest {

        public int Id { get; set; }
        public int QuestId { get; set; }
        public Quest? Quest { get; set; } = null;

        public int TeamId { get; set; }
        public Team? Team { get; set; } = null;
    }
}
