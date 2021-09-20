using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakerHubAPI.DAL.Entities {
    public class TypeSouper {

        public int ID {  get; set; }
        public string Nom {  get; set; }
        public IEnumerable<Souper> Soupers { get; set; }

    }
}
