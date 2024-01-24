namespace KarmaLympics.Models {

    public class Challenge {

        public int Id { get; set; }
        public string ChallengeName { get; set; } = string.Empty;
        public int MaxPoints { get; set; }
        public int GivenPoints { get; set; }
        public string Solution { get; set; } = string.Empty;
        public int QuestId { get; set; }

        //Navigation Property

        public Quest? Quest { get; set; } = null;

    }
}

