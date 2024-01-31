namespace KarmaLympics.Dto {

    public class EventDto {

        public int Id { get; set; }
        public string EventName { get; set; } = string.Empty;
        public string HostName { get; set; } = string.Empty;
        public string HostMail { get; set; } = string.Empty;
        public string Rules { get; set; } = string.Empty;
    }
}
