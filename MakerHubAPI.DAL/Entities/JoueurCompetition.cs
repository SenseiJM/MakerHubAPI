using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakerHubAPI.DAL.Entities {
    public class JoueurCompetition {

        public int IDJoueur { get; set; }
        public int IDCompetition { get; set; }
        public Joueur Joueur { get; set; }
        public Competition Competition { get; set; }

    }
}
