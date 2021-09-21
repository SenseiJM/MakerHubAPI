using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MakerHubAPI.DTO.CategorieAge {
    public class CategorieAgeAddDTO {

        [Required]
        [MaxLength(50)]
        public string Nom { get; set; }

        [Required]
        [MaxLength(6)]
        public string Genre { get; set; }

    }
}
