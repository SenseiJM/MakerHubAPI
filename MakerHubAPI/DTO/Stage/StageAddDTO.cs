using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MakerHubAPI.DTO.Stage {
    public class StageAddDTO {

        [Required]
        public DateTime DateDebut { get; set; }

        [Required]
        public DateTime DateFin { get; set; }

        [Required]
        public TimeSpan HeureDebut { get; set; }

        [Required]
        public TimeSpan HeureFin { get; set; }

        [Required]
        public double PrixAffilies { get; set; }

        [Required]
        public double PrixExternes { get; set; }

        [Required]
        public int IDClassementMinimum {get;set; }

        [Required]
        public int IDClassementMaximum { get; set; }

        [Required]
        [MaxLength(50)]
        public string Entraineur { get; set; }

        public int? NombreMax { get; set; }

        [Required]
        [MaxLength(1500)]
        public string Description { get; set; }

    }
}
