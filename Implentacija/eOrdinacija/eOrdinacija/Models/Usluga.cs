using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eOrdinacija.Models
{
    public class Usluga
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obavezna vrijednost")]
        public string Naziv { get; set; }

        [Required(ErrorMessage = "Obavezna vrijednost")]
        public string Opis { get; set; }
    }
}
