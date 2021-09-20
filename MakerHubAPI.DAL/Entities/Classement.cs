using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakerHubAPI.DAL.Entities {
    public class Classement {

        public int ID {  get; set; }
        public string Denomination {  get; set; }
        public IEnumerable<Competition> Competitions { get; set; }
        public IEnumerable<Stage> Stages { get; set; }
        public IEnumerable<Joueur> Joueurs { get; set; }

    }
}
