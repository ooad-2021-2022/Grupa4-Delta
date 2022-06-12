using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eOrdinacija.Models
{
    public class Nalaz
    {
        public enum ParametriNalaza { eritrociti, leukociti, hemoglobin, kreating, ggt, zeljezo, trombociti};

        [Key]
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obavezna vrijednost")]
        public DateTime datumVrijeme { get; set; }

        [Required(ErrorMessage = "Obavezna vrijednost")]
        public Pacijent Pacijent { get; set; }

        [Required(ErrorMessage = "Obavezna vrijednost")]
        public List<ParametriNalaza> NazivParametra { get; set; }

        [Required(ErrorMessage = "Obavezna vrijednost")]
        public List<int> VrijednostiParametara { get; set; }

        [Required(ErrorMessage = "Obavezna vrijednost")]
        public string QrCode { get; set; }

        [Required(ErrorMessage = "Obavezna vrijednost")]
        public Karton Karton { get; set; }
    }
}
