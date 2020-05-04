using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UpCycling.Models.AgendaController
{
    public class ShowEventVueModel
    {
        public int Id { get; set; }

        public string Nom { get; set; }

        public int Prix { get; set; }

        public DateTime Date { get; set; }

        public string Description { get; set; }
    }
}
