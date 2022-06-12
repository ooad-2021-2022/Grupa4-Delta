using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eOrdinacija.Models
{
    public class Dijagnoza
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obavezna vrijednost")]
        public string Naziv { get; set; }

        [Required(ErrorMessage = "Obavezna vrijednost")]
        public string Opis { get; set; }

        [Required(ErrorMessage = "Obavezna vrijednost")]
        public DateTime datumUspostave { get; set; }

        [Required(ErrorMessage = "Obavezna vrijednost")]
        public Boolean Terapija { get; set; }

        [Required(ErrorMessage = "Obavezna vrijednost")]
        public Karton Karton { get; set; }


    }
}
