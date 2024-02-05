using KarmaLympics.Data;
using KarmaLympics.Interfaces;
using KarmaLympics.Models;

namespace KarmaLympics.Repository {

    public class QuestRepository : IQuestRepository {

        private readonly AppDbContext _context;

        public QuestRepository(AppDbContext context) {

            _context = context;
        }

        public Quest GetQuest(int questId) {

            return _context.Quests.First(q => q.Id == questId);

        }
    }
}
