namespace KarmaLympics.Models {

    public class Event {

        public int Id { get; set; }
        public string EventName { get; set; } = string.Empty;
        public string HostName { get; set; } = string.Empty;
        public string HostMail { get; set; } = string.Empty;
        public string Rules { get; set; } = string.Empty;

        //Navigaton Property

        public ICollection<Team> Teams { get; set; }
        public Quest? Quest { get; set; } = null;
    }
}
