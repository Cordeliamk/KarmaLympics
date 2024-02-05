using KarmaLympics.Data;
using KarmaLympics.Dto;
using KarmaLympics.Interfaces;
using KarmaLympics.Models;

namespace KarmaLympics.Repository {

    public class TeamRepository : ITeamRepository {

        private readonly AppDbContext _context;

        public TeamRepository(AppDbContext context) {
            _context = context;
        }

        public ICollection<Team> GetTeams() {

            return _context.Teams.ToList();
        }

        public Team GetTeam(int teamId) {

            return _context.Teams.First(t => t.Id == teamId);
        }

        public bool TeamExists(int teamId) {

            return _context.Teams.Any(t => t.Id == teamId);
        }

        public bool CreateTeam(TeamDto teamDto) {

            var team = new Team() {

                TeamName = teamDto.TeamName,
                EventId = teamDto.EventId,

            };

            _context.Teams.Add(team);
            Save();
            return true;
        }

        public bool Save() {

            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }
    }
}
