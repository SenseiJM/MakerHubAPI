using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MakerHubAPI.DTO.TypeSouper {
    public class TypeSouperAddDTO {

        [Required]
        [MaxLength(10)]
        public string Nom { get; set; }

    }
}
