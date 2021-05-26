using EventsOrganizer.Entities;
using EventsOrganizer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsOrganizer.Serveces
{
    public interface IEventService
    {
        public List<GetEventDtoAdmin> GetEventsForAdmin();
        public List<GetEventDtoMember> GetEventsForMember();
        public List<GetEventDtoMember> SearchBySubiect(string subject);
        public Guid CreateEvent(CreateEventDto dto);
        public bool DeleteEvent(Guid guid);
    }
}
