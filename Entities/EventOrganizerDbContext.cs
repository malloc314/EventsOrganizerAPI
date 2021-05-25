using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsOrganizer.Entities
{
    public class EventOrganizerDbContext : DbContext
    {
        public EventOrganizerDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Event> Events { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Member> Members { get; set; }
    }
}
