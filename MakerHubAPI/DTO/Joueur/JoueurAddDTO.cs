using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MakerHubAPI.DTO {
    public class JoueurAddDTO {

        [Required]
        [MaxLength(50)]
        public string Nom { get; set; }

        [Required]
        [MaxLength(50)]
        public string Prenom { get; set; }

        [Required]
        public int IDClassementHommes { get; set; }
        public int? IDClassementDames { get; set; }

        [Required]
        public int IDCategorieAge { get; set; }

        [Required]
        [MaxLength(6)]
        public string Genre { get; set; }

        public int? IDEquipeHommes { get; set; }
        public int? IDEquipeDames { get; set; }

    }
}
