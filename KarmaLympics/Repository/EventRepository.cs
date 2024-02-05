using KarmaLympics.Data;
using KarmaLympics.Dto;
using KarmaLympics.Interfaces;
using KarmaLympics.Models;

namespace KarmaLympics.Repository {

    public class EventRepository : IEventRepository {

        private readonly AppDbContext _context;

        public EventRepository(AppDbContext context) {

            _context = context;
        }

        public ICollection<Event> GetEvents() {

            return _context.Events.ToList();
        }

        public Event GetEvent(int eventId) {

            return _context.Events.First(e => e.Id == eventId);

        }
        public bool EventExists(int eventId) {

            return _context.Events.Any(e => e.Id == eventId);
        }

        public bool CreateEvent(EventDto eventDto) {

            Event createdEvent = new Event {

                EventName = eventDto.EventName,
                HostName = eventDto.HostName,
                HostMail = eventDto.HostMail


            };
            _context.Events.Add(createdEvent);
            return Save();
        }

        public bool Save() {

            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }
    }
}
