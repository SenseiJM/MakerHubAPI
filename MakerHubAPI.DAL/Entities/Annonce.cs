using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakerHubAPI.DAL.Entities {
    public class Annonce {

        public int ID {  get; set; }
        public string Titre {  get; set; }
        public byte[]? Photo {  get; set; }
        public string Description {  get; set; }

    }
}
