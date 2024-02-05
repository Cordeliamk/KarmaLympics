using KarmaLympics.Models;

namespace KarmaLympics.Interfaces {

    public interface IQuestRepository {

        public Quest GetQuest(int questId);

    }
}
