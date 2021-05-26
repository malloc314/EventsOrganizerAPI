using AutoMapper;
using EventsOrganizer.Entities;
using EventsOrganizer.Models;
using EventsOrganizer.Serveces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsOrganizer.Controllers
{
    [ApiController]
    [Route("api/event")]
    public class EventController : ControllerBase
    {
        private readonly IEventService _service;

        public EventController(IEventService service)
        {
            _service = service;
        }

        [HttpGet("admin")]
        public ActionResult<IEnumerable<GetEventDtoAdmin>> GetAllForAdmin()
        {
            var events = _service.GetEventsForAdmin();

            return Ok(events);
        }
        
        [HttpGet("member")]
        public ActionResult<IEnumerable<GetEventDtoMember>> GetAllForMember()
        {
            var events = _service.GetEventsForMember();

            return Ok(events);
        }

        [HttpGet("{subiect}")]
        public ActionResult<IEnumerable<GetEventDtoMember>> Search([FromRoute] string subject)
        {
            var events = _service.SearchBySubiect(subject);
            
            return Ok(events);
        }

        [HttpPost]
        public ActionResult Create([FromBody] CreateEventDto dto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var guidEvent = _service.CreateEvent(dto);

            return Created($"api/event/{guidEvent}", null);
        }

        [HttpDelete("{guid}")]
        public ActionResult Delete([FromRoute] Guid guid)
        {
            var isDeleted = _service.DeleteEvent(guid);

            if (isDeleted)
                return NoContent();
           
            return NotFound();
        }

    }
}
