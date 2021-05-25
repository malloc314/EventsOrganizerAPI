using AutoMapper;
using EventsOrganizer.Entities;
using EventsOrganizer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsOrganizer.Serveces
{
    public class MemberService : IMemberService
    {
        private readonly EventOrganizerDbContext _dbContext;
        private readonly IMapper _mapper;

        public MemberService(EventOrganizerDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public bool CreateMember(CreateMemberDto dto)
        {
            var getEvent = _dbContext.Events.FirstOrDefault(e => e.Guid == dto.EventGuid);

            if (getEvent is null)
                return false;

            if (getEvent.Limit <= 0)
                return false;

            getEvent.Limit -= 1;

            var mappingMember = _mapper.Map<Member>(dto);

            _dbContext.Add(mappingMember);
            _dbContext.SaveChanges();

            return true;
        }
    }
}
