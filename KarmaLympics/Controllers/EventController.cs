
using KarmaLympics.Interfaces;
using KarmaLympics.Models;
using Microsoft.AspNetCore.Mvc;

namespace KarmaLympics.Controllers {


    [Route("api/[controller]")]
    [ApiController]

    public class EventController : Controller {

        private readonly IEventRepository _eventRepository;

        public EventController(IEventRepository eventRepository) {
            _eventRepository = eventRepository;
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Event>))]

        public IActionResult GetEvents() {

            var events = _eventRepository.GetEvents();

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(events);
        }
    }
}
