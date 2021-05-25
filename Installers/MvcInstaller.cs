using EventsOrganizer.Entities;
using EventsOrganizer.Serveces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EventsOrganizer.Installers
{
    public class MvcInstaller : IInstaller
    {
        public void InstallServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<EventOrganizerDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("EventOrganizerCS")));

            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            services.AddScoped<IEventService, EventService>();
            services.AddScoped<IMemberService, MemberService>();

            services.AddControllers();
        }
    }
}
