using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UpCycling.Data.Entity;

namespace UpCycling.Service.Interface
{
    public interface IEventServices
    {
        void CreateEvent(string nom, int prix, DateTime date, string desc, string lieu, int place);

        IEnumerable<Event> GetAllEvents();

        Event GetEvent(int idEvent);
    }
}
