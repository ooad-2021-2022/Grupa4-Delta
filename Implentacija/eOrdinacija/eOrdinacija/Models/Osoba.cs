using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eOrdinacija.Models
{
    public abstract class Osoba
    {
        public enum Uloga { pacijent, administrator, uposlenik };
        public enum Spol { muski, zenski, bez_izjasnjenja };
        public enum Specijalizacija { pedijatrija, hirurgija, infektologija, kardiologija, radiologija, opsta_praksa, psihijatrija, dermatlogoija };

        [Key]
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obavezna vrijednost")]
        public string Ime { get; set; }

        [Required(ErrorMessage = "Obavezna vrijednost")]
        public string Prezime { get; set; }

        [Required(ErrorMessage = "Obavezna vrijednost")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Obavezna vrijednost")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Obavezna vrijednost")]
        public Uloga UlogaUsistemu { get; set; }

        [Required(ErrorMessage = "Obavezna vrijednost")]
        public DateTime datumRodjenja { get; set; }

        [Required(ErrorMessage = "Obavezna vrijednost")]
        public Spol spol { get; set; }

        [Required(ErrorMessage = "Obavezna vrijednost")]
        public Specijalizacija specijalizacija { get; set; }

    }


}
