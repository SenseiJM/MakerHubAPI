using MakerHubAPI.DAL.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MakerHubAPI.DTO.Stage {
    public class StageAddDTO {

        [Required]
        [MaxLength(100)]
        public string Titre { get; set; }

        [Required]
        //Moyen de mettre en JSON (Quel type d'entrée/de formatage est désiré)
        public DateTime DateDebut { get; set; }

        [Required]
        public DateTime DateFin { get; set; }

        [Required]
        [MaxLength(5)]
        public string HeureDebut { get; set; }

        [Required]
        [MaxLength(5)]
        public string HeureFin { get; set; }

        [Required]
        public double PrixAffilies { get; set; }

        [Required]
        public double PrixExternes { get; set; }

        [Required]
        public Classements ClassementMinimum {get;set; }

        [Required]
        public Classements ClassementMaximum { get; set; }

        [Required]
        [MaxLength(50)]
        public string Entraineur { get; set; }

        public int? NombreMax { get; set; }

        [Required]
        [MaxLength(1500)]
        public string Description { get; set; }

    }
}
