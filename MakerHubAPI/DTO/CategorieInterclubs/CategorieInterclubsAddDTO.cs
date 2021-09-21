using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MakerHubAPI.DTO.CategorieInterclubs {
    public class CategorieInterclubsAddDTO {

        [Required]
        [MaxLength(6)]
        public string Genre { get; set; }

    }
}
