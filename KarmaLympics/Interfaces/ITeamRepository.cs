using KarmaLympics.Models;

namespace KarmaLympics.Interfaces {

    public interface ITeamRepository {

        public ICollection<Team> GetTeams();
        public Team GetTeam(int teamId);
        public bool TeamExists(int teamId);
    }
}
