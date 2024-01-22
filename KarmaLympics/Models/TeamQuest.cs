namespace KarmaLympics.Models {

    public class TeamQuest {

        public int QuestId { get; set; }
        public Quest Quest { get; set; }

        public int TeamId { get; set; }
        public Team Team { get; set; }
    }
}
