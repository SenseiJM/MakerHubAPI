using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakerHubAPI.DAL.Entities {
    public class Classement {

        public int ID {  get; set; }
        public string Denomination {  get; set; }
        public IEnumerable<Competition> CompetitionsMin { get; set; }
        public IEnumerable<Competition> CompetitionsMax { get; set; }
        public IEnumerable<Stage> StagesMin { get; set; }
        public IEnumerable<Stage> StagesMax { get; set; }
        public IEnumerable<Joueur> JoueursHommes { get; set; }
        public IEnumerable<Joueur> JoueursDames { get; set; }

    }
}
