using EventsOrganizer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsOrganizer.Serveces
{
    public interface IMemberService
    {
        public bool CreateMember(CreateMemberDto dto);
    }
}
