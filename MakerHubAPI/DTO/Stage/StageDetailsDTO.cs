using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MakerHubAPI.DTO.Stage {
    public class StageDetailsDTO {

        public DateTime DateDebut { get; set; }
        public DateTime DateFin { get; set; }
        public string HeureDebut { get; set; }
        public string HeureFin { get; set; }
        public double PrixAffilies { get; set; }
        public double PrixExternes { get; set; }
        public int IDClassementMinimum { get; set; }
        public int IDClassementMaximum { get; set; }
        public string Entraineur { get; set; }
        public int? NombreMax { get; set; }
        public string Description { get; set; }
        //public IEnumerable<JoueurIndexDTO> Joueurs { get; set; }


    }
}
