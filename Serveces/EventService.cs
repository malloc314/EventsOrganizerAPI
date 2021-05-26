using AutoMapper;
using EventsOrganizer.Entities;
using EventsOrganizer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsOrganizer.Serveces
{
    public class EventService : IEventService
    {
        private readonly EventOrganizerDbContext _dbContext;
        private readonly IMapper _mapper;

        public EventService(EventOrganizerDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public List<GetEventDtoAdmin> GetEventsForAdmin()
        {
            var events = _dbContext.Events
                .Include(e => e.Address)
                .Include(e => e.Members)
                .ToList();

            var mappingEvent = _mapper.Map<List<GetEventDtoAdmin>>(events);

            return mappingEvent;
        }
        
        public List<GetEventDtoMember> GetEventsForMember()
        {
            var events = _dbContext.Events
                .Include(e => e.Address)
                .ToList();

            var mappingEvent = _mapper.Map<List<GetEventDtoMember>>(events);

            return mappingEvent;
        }

        public List<GetEventDtoMember> SearchBySubject(string subject)
        {
            var events = _dbContext.Events
                .Where(e => e.Subiect.ToLower().Contains(subject.ToLower()))
                .Include(e => e.Address)
                .ToList();

            var mappingEvent = _mapper.Map<List<GetEventDtoMember>>(events);

            return mappingEvent;
        }

        public Guid CreateEvent(CreateEventDto dto)
        {
            var mappingEvent = _mapper.Map<Event>(dto);
            
            var url = string.IsNullOrEmpty(mappingEvent.Address.Url) ? false : true;
            var limit = mappingEvent.Limit == 0 ? false : true;
            
            mappingEvent.IsOnline = url;
            mappingEvent.IsLimit = limit;
   
            _dbContext.Add(mappingEvent);
            _dbContext.SaveChanges();

            return mappingEvent.Guid;
        }

        public bool DeleteEvent(Guid guid)
        {
            var events = _dbContext.Events
                .FirstOrDefault(e => e.Guid == guid);

            var addressGuid = events.AddressGuid;

            var addresses = _dbContext.Addresses
                .FirstOrDefault(a => a.Guid == addressGuid);

            if (events is null && addresses is null)
                return false;

            _dbContext.Remove(events);
            _dbContext.Remove(addresses);
            _dbContext.SaveChanges();

            return true;
        }
    }
}
