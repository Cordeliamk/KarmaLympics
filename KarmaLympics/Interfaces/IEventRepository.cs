using KarmaLympics.Dto;
using KarmaLympics.Models;

namespace KarmaLympics.Interfaces {

    public interface IEventRepository {

        ICollection<Event> GetEvents();
        public Event GetEvent(int eventId);
        public bool EventExists(int eventId);
        public bool CreateEvent(EventDto eventDto);
        public bool Save();
    }
}
