using KarmaLympics.Models;

namespace KarmaLympics.Interfaces {

    public interface IEventRepository {

        ICollection<Event> GetEvents();

    }
}
