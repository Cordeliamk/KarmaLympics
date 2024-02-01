using KarmaLympics.Data;
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
    }
}
