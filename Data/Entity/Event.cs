using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UpCycling.Data.Entity
{
    public class Event
    {
        public int Id { get; set; }

        public string Nom { get; set; }

        public DateTime Date { get; set; }

        public int Prix { get; set; }

        public string Description { get; set; }

        public string Lieu { get; set; }

        public int Place { get; set; }

        public virtual IEnumerable<LiaisonUserEvent> Users { get; set; }
    }
}
