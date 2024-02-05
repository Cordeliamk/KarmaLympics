using KarmaLympics.Dto;
using KarmaLympics.Models;

namespace KarmaLympics.Interfaces {

    public interface IChallengeRepository {

        ICollection<Challenge> GetChallenge();
        public Challenge GetChallenge(int challengeId);
        public bool ChallengeExists(int challengeId);
        public bool CreateChallenge(ChallengeDto challengeDto);
        public bool Save();
    }
}
