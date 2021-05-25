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
    [Route("api/member")]
    public class MemberController : ControllerBase
    {
        private readonly IMemberService _service;

        public MemberController(IMemberService service)
        {
            _service = service;
        }

        [HttpPost]
        public ActionResult Create([FromBody] CreateMemberDto dto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var member = _service.CreateMember(dto);

            if (!member)
                return NotFound("Brak wolnych miejsc lub wydarzenia o podanym identyfikatorze");

            return Created("Użytkownik został dodany do wydarzenia", null);
        }
    }
}
