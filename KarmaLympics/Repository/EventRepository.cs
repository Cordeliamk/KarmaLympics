using KarmaLympics.Data;
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
    }
}
