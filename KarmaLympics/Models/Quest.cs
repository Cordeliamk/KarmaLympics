namespace KarmaLympics.Models {

    public class Quest {

        public int Id { get; set; }
        public string Name { get; set; }
        public bool HostQuest { get; set; }


        //Navigation Property

        public ICollection<Team> Teams { get; set; }
        public Event Event { get; set; }
        public ICollection<TeamQuest> TeamQuests { get; set; }

    }
}
