using AutoMapper;
using KarmaLympics.Dto;
using KarmaLympics.Interfaces;
using KarmaLympics.Models;
using Microsoft.AspNetCore.Mvc;

namespace KarmaLympics.Controllers {


    [Route("api/[controller]")]
    [ApiController]

    public class EventController : Controller {

        private readonly IEventRepository _eventRepository;
        private readonly IMapper _mapper;

        public EventController(IEventRepository eventRepository, IMapper mapper) {
            _eventRepository = eventRepository;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Event>))]

        public IActionResult GetEvents() {

            var events = _mapper.Map<List<EventDto>>(_eventRepository.GetEvents());

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(events);
        }

        [HttpGet("{eventId}")]
        [ProducesResponseType(200, Type = typeof(Event))]
        [ProducesResponseType(400)]

        public IActionResult GetEvent(int eventId) {

            if (!_eventRepository.EventExists(eventId))
                return NotFound();

            var singleEvent = _mapper.Map<EventDto>(_eventRepository.GetEvent(eventId));

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(singleEvent);
        }

        [HttpPost]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]

        public IActionResult CreateEvent(EventDto eventDto) {

            _eventRepository.CreateEvent(eventDto);



            return Ok("Created succesfully");
        }
    }
}
