using MakerHubAPI.Validators;
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

        //Taille de 2Mo
        [MaxLength(2 * 1024 * 1024)]
        public byte[] Photo { get; set; }


        //Gère l'extension du fichier
        [MimeTypeValidator("image/jpg", "image/jpeg", "image/svg", "image/png")]
        public string MimeType { get; set; }

        [Required]
        [MaxLength(1500)]
        public string Description { get; set; }

    }
}
