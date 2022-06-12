using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eOrdinacija.Models
{
    public class Pacijent : Osoba
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obavezna vrijednost")]
        public String Biljeska { get; set; }

        [Required(ErrorMessage = "Obavezna vrijednost")]
        public Osoba Osoba { get; set; }
    }
}
