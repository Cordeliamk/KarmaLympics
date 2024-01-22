namespace KarmaLympics.Models {

    public class Event {

        public int Id { get; set; }
        public string EventName { get; set; }
        public string HostName { get; set; }
        public string HostMail { get; set; }
        public string Rules { get; set; }

        //Navigaton Property

        public ICollection<Team> Teams { get; set; }
        public Quest Quest { get; set; }
    }
}
