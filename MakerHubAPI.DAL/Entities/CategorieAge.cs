using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakerHubAPI.DAL.Entities {
    public class CategorieAge {

        public int ID {  get; set; }
        public string Nom {  get; set; }
        public string Genre {  get; set; }
        public IEnumerable<Competition> Competitions {  get; set; }
        public IEnumerable<Joueur> Joueurs { get; set; }

    }
}
