using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MakerHubAPI.DTO.Annonce {
    public class AnnonceAddDTO {

        [Required]
        [MaxLength(255)]
        public string Titre { get; set; }

        public byte[]? Photo { get; set; }

        [Required]
        [MaxLength(1500)]
        public string Description { get; set; }

    }
}
