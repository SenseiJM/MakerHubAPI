using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MakerHubAPI.DTO.Souper {
    public class SouperAddDTO {

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public int IDType { get; set; }

        [Required]
        public double PrixAffilies { get; set; }

        [Required]
        public double PrixExternes { get; set; }

        [Required]
        [MaxLength(1500)]
        public string Description { get; set; }
        
        public byte[]? Photo { get; set; }

        public int? NombreMax { get; set; }

        [Required]
        [MaxLength(50)]
        public string Titre { get; set; }

    }
}
