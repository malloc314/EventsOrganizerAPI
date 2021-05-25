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
    public class GetMemberDto : IMap
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Email { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Member, GetMemberDto>();
        }
    }
}
