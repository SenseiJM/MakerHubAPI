using MakerHubAPI.DAL.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakerHubAPI.DAL.Entities {
    public class Joueur {

        public int ID { get; set; }
        public int IDAFTT { get; set; }
        public string IdentifiantConnexion { get; set; }
        public string MotDePasse { get; set; }
        public int? IDEquipeHommes { get; set; }
        public int? IDEquipeDames { get; set; }
        public string? HeureDepartHommes { get; set; }
        public string? HeureDepartDames { get; set; }
        public IEnumerable<JoueurCompetition> JoueurCompetitions { get; set; }
        public IEnumerable<JoueurStage> JoueurStages { get; set; }

    }
}
