using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UpCycling.Data.Entity;

namespace UpCycling.Service.Interface
{
    public interface ILiaison
    {
        void CreateLiaison(int idEvent, int idUser);

        IEnumerable<LiaisonUserEvent> GetAllLiaison();
    }
}
