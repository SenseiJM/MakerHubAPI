using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MakerHubAPI.DTO.Equipe {
    public class EquipeAddDTO {

        [Required]
        [MaxLength(8)]
        public string Nom { get; set; }

        [Required]
        public int IDCategorieInterclubs { get; set; }

        [Required]
        [MaxLength(50)]
        public string LieuMatch { get; set; }

        [Required]
        public TimeSpan HeureMatch { get; set; }

        public TimeSpan? HeureDepart { get; set; }

        [Required]
        [MaxLength(7)]
        public string Division { get; set; }

    }
}
