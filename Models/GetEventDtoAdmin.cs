using AutoMapper;
using EventsOrganizer.Entities;
using EventsOrganizer.Mappings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsOrganizer.Models
{
    public class GetEventDtoAdmin : IMap
    {
        public Guid Guid { get; set; }
        public string Subiect { get; set; }
        public string Description { get; set; }
        public int Limit { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string PostalCode { get; set; }
        public string Url { get; set; }
        public bool IsOnline { get; set; }
        public bool IsLimit { get; set; }
        public List<GetMemberDto> Members { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Event, GetEventDtoAdmin>()
                .ForMember(m => m.City, c => c.MapFrom(s => s.Address.City))
                .ForMember(m => m.Street, c => c.MapFrom(s => s.Address.Street))
                .ForMember(m => m.PostalCode, c => c.MapFrom(s => s.Address.PostalCode))
                .ForMember(m => m.Url, c => c.MapFrom(s => s.Address.Url));
        }
    }
}
