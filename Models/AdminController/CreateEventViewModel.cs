using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UpCycling.Models.AdminController
{
    public class CreateEventViewModel
    {
        [Required]
        public string Nom { get; set; }

        [Required]
        public string Desc { get; set; }

        [Required]
        public int Prix { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        [Required]
        public string Lieu { get; set; }

        [Required]
        public int Place { get; set; }
    }
}
