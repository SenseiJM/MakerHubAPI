using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MakerHubAPI.DTO.Souper {
    public class SouperDetailsDTO {

        public DateTime Date { get; set; }
        public int IDType { get; set; }
        public double PrixAffilies { get; set; }
        public double PrixExternes { get; set; }
        public string Description { get; set; }
        public byte[]? Photo { get; set; }
        public int? NombreMax { get; set; }
        public string Titre { get; set; }

    }
}
