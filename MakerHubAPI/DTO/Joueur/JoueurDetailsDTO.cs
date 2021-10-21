using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MakerHubAPI.DTO {
    public class JoueurDetailsDTO {

        public int ID { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public int IDClassementHommes { get; set; }
        public string ClassementHommes { get; set; }
        public int? IDClassementDames { get; set; }
        public string ClassementDames { get; set; }
        public int IDCategorieAge { get; set; }
        public string Genre { get; set; }
        public int? IDEquipeHommes { get; set; }
        public int? IDEquipeDames { get; set; }
        //Récupérer directement les noms des équipes, ... au lieu des ID

    }
}
