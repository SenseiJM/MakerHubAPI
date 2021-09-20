using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakerHubAPI.DAL.Entities {
    public class Equipe {

        public int ID {  get; set; }
        public string Nom {  get; set; }
        public int IDCategorieInterclubs {  get; set; }
        public string LieuMatch {  get; set; }
        public TimeSpan HeureMatch {  get; set; }
        public TimeSpan? HeureDepart {  get; set; }
        public string Division {  get; set; }
        public CategorieInterclubs CategorieInterclubs { get; set; }
        public IEnumerable<Joueur> Joueurs { get; set; }

    }
}
