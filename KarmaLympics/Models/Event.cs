namespace KarmaLympics.Models {

    public class Event {

        public int Id { get; set; } //PK
        public string EventName { get; set; } = string.Empty;
        public string HostName { get; set; } = string.Empty;
        public string HostMail { get; set; } = string.Empty;
        public string EventDescription { get; set; } = string.Empty;

        //Navigaton Property

        public ICollection<Team>? Teams { get; set; } = null;
        public Quest? Quest { get; set; } = null;
    }
}
