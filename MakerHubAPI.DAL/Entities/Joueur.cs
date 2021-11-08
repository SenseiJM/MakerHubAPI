using MakerHubAPI.DAL.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakerHubAPI.DAL.Entities {
    public class Joueur {

        public int ID {  get; set; }
        public string Nom {  get; set; }
        public string Prenom {  get; set; }
        public int IDClassementHommes {  get; set; }
        public int? IDClassementDames {  get; set; }
        public int IDCategorieAge {  get; set; }
        public string Genre {  get; set; }
        public int? IDEquipeHommes {  get; set; }
        public int? IDEquipeDames {  get; set; }
        public Classements ClassementHommes { get; set; }
        public Classements? ClassementDames { get; set; }
        public Equipe? EquipeHommes { get; set; }
        public Equipe? EquipeDames { get; set; }
        public CategorieAge CategorieAge { get; set; }
        public IEnumerable<JoueurCompetition> JoueurCompetitions { get; set; }
        public IEnumerable<JoueurStage> JoueurStages { get; set; }

    }
}
