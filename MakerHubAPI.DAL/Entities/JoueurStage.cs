using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakerHubAPI.DAL.Entities {
    public class JoueurStage {

        public int IDJoueur { get; set; }
        public int IDStage { get; set; }
        public Stage Stage { get; set; }
        public Joueur Joueur { get; set; }

    }
}
