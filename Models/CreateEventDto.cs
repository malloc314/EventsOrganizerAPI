using AutoMapper;
using EventsOrganizer.Entities;
using EventsOrganizer.Mappings;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsOrganizer.Models
{
    public class CreateEventDto : IMap
    {
        [Required]
        [MaxLength(64)]
        public string Subiect { get; set; }
        
        [Required]
        [MaxLength(255)]
        public string Description { get; set; }
        
        [Range(0, 25)]
        public int Limit { get; set; }
        
        public string City { get; set; }
        
        public string Street { get; set; }
        
        public string PostalCode { get; set; }
        
        public string Url { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<CreateEventDto, Event>()
                .ForMember(r => r.Address, 
                    c => c.MapFrom(dto => new Address() 
                    {
                        City = dto.City,
                        Street = dto.Street,
                        PostalCode = dto.PostalCode,
                        Url = dto.Url
                    }));
        }
    }
}
