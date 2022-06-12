using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eOrdinacija.Models
{
    public enum ParametriNalaza { eritrociti, leukociti, hemoglobin, kreating, ggt, zeljezo, trombociti };

    public class ParametriNalaz
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obavezna vrijednost")]
        public int NalazId { get; set; }

        [Required(ErrorMessage = "Obavezna vrijednost")]
        public String ParametriNalaza { get; set; }

        [Required(ErrorMessage = "Obavezna vrijednost")]
        public double Vrijednost { get; set; }
    }
}
