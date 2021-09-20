using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MakerHubAPI.DTO {
    public class JoueurDetailsDTO {

        public string Nom { get; set; }
        public string Prenom { get; set; }
        public int IDClassementHommes { get; set; }
        public int? IDClassementDames { get; set; }
        public int IDCategorieAge { get; set; }
        public string Genre { get; set; }
        public int? IDEquipeHommes { get; set; }
        public int? IDEquipeDames { get; set; }

    }
}
