using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UpCycling.Models.AgendaController
{
    public class ReserveEventViewModel
    {
        public int IdEvent { get; set; }

        public string NomEvent { get; set; }

        public int PlacLibre { get; set; }

        public int IdUser { get; set; }

        public int PlacePrise { get; set; }
    }
}
