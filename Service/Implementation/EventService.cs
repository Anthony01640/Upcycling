using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UpCycling.Data;
using UpCycling.Data.Entity;
using UpCycling.Service.Interface;

namespace UpCycling.Service.Implementation
{
    public class EventService : IEventServices
    {
        public EventService(ApplicationDbContext context)
        {
            Context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public ApplicationDbContext Context { get; }


        public void CreateEvent(string nom, int prix, DateTime date, string desc, string lieu, int place)
        {
            var newevent = new Event
            {
                Date = date,
                Description = desc,
                Nom = nom,
                Prix = prix,
                Lieu = lieu,
                Place = place,
            };
            Context.Events.Add(newevent);
            Context.SaveChanges();
        }

        public IEnumerable<Event> GetAllEvents()
        {
            return Context.Events;
        }

        public Event GetEvent(int idEvent)
        {
            return Context.Events.FirstOrDefault(m => m.Id == idEvent);
        }
    }
}
