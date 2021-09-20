using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakerHubAPI.DAL.Entities {
    public class CategorieInterclubs {

        public int ID {  get; set; }
        public string Genre {  get; set; }
        public IEnumerable<Equipe> Equipes { get; set; }

    }
}
