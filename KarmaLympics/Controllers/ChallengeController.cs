using AutoMapper;
using KarmaLympics.Dto;
using KarmaLympics.Interfaces;
using KarmaLympics.Models;
using Microsoft.AspNetCore.Mvc;

namespace KarmaLympics.Controllers {


    [Route("api/[controller]")]
    [ApiController]

    public class ChallengeController : Controller {

        private readonly IChallengeRepository _challengeRepository;
        private readonly IMapper _mapper;

        public ChallengeController(IChallengeRepository challengeRepository, IMapper mapper) {
            _challengeRepository = challengeRepository;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Challenge>))]
        public IActionResult GetChallenges() {

            var challenge = _mapper.Map<List<ChallengeDto>>(_challengeRepository.GetChallenge());

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(challenge);
        }
    }
}
