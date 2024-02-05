using KarmaLympics.Dto;
using KarmaLympics.Models;

namespace KarmaLympics.Interfaces {

    public interface ITeamRepository {

        public ICollection<Team> GetTeams();
        public Team GetTeam(int teamId);
        public bool TeamExists(int teamId);
        public bool CreateTeam(TeamDto teamDto);
        public bool Save();
    }
}
