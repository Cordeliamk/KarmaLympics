using KarmaLympics.Data;
using KarmaLympics.Dto;
using KarmaLympics.Interfaces;
using KarmaLympics.Models;

namespace KarmaLympics.Repository {

    public class ChallengeRepository : IChallengeRepository {

        private readonly AppDbContext _context;

        public ChallengeRepository(AppDbContext context) {
            _context = context;
        }

        public ICollection<Challenge> GetChallenge() {

            return _context.Challenges.ToList();
        }

        public Challenge GetChallenge(int challengeId) {

            return _context.Challenges.First(c => c.Id == challengeId);
        }

        public bool ChallengeExists(int challengeId) {

            return _context.Challenges.Any(c => c.Id == challengeId);
        }

        public bool CreateChallenge(ChallengeDto challengeDto) {

            Challenge challenge = new Challenge() {

                ChallengeName = challengeDto.ChallengeName,
                MaxPoints = challengeDto.MaxPoints,
                // QuestId = challengeDto.QuestId,
            };
            _context.Challenges.Add(challenge);
            return Save();
        }

        public bool Save() {

            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }
    }
}
