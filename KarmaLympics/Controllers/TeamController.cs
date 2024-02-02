using AutoMapper;
using KarmaLympics.Dto;
using KarmaLympics.Interfaces;
using KarmaLympics.Models;
using Microsoft.AspNetCore.Mvc;

namespace KarmaLympics.Controllers {

    [Route("api/[controller]")]
    [ApiController]

    public class TeamController : Controller {

        public readonly ITeamRepository _teamRepository;
        private readonly IMapper _mapper;

        public TeamController(ITeamRepository teamRepository, IMapper mapper) {
            _teamRepository = teamRepository;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Team>))]

        public IActionResult GetTeams() {

            var teams = _mapper.Map<List<TeamDto>>(_teamRepository.GetTeams());

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(teams);
        }

        [HttpGet("{teamId}")]
        [ProducesResponseType(200, Type = typeof(Team))]
        [ProducesResponseType(400)]

        public IActionResult GetTeam(int teamId) {

            if (!_teamRepository.TeamExists(teamId))
                return NotFound();

            var team = _mapper.Map<TeamDto>(_teamRepository.GetTeam(teamId));

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(team);
        }
    }
}
