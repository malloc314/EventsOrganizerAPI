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
    public class CreateMemberDto : IMap
    {
        [Required]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public Guid EventGuid { get; set; }
        
        
        public void Mapping(Profile profile)
        {
            profile.CreateMap<CreateMemberDto, Member>();
        }
    }
}
