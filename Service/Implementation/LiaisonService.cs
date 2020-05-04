using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UpCycling.Data;
using UpCycling.Data.Entity;
using UpCycling.Service.Interface;

namespace UpCycling.Service.Implementation
{
    public class LiaisonService : ILiaison
    {
        public LiaisonService(ApplicationDbContext context )
        {
            Context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public ApplicationDbContext Context { get; }

        public void CreateLiaison(int idEvent, int idUser)
        {
            var newLiaison = new LiaisonUserEvent
            {
                EventId = idEvent,
                UserId = idUser,
            };
            Context.Liaisons.Add(newLiaison);
            Context.SaveChanges();
        }

        public IEnumerable<LiaisonUserEvent> GetAllLiaison()
        {
            return Context.Liaisons;
        }
    }
}
