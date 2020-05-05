using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UpCycling.Models.AdminController
{
    public class AllUser
    {
        public IEnumerable<GetUserViewModel> ListeUser { get; set; }
    }
}
