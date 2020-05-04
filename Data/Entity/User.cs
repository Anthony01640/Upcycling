using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UpCycling.Data.Entity
{
    public class User
    {
        public int Id { get; set; }

        public string Mail { get; set; }

        public virtual IEnumerable<LiaisonUserEvent> Events { get; set; }
    }
}
