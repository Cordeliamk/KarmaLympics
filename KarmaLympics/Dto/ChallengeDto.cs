namespace KarmaLympics.Dto {

    public class ChallengeDto {

        public int Id { get; set; }
        public string ChallengeName { get; set; } = string.Empty;
        public int MaxPoints { get; set; }
        public string Solution { get; set; } = string.Empty;
        public int QuestId { get; set; }
    }
}
