using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MakerHubAPI.DTO.Annonce {
    public class AnnonceDetailsDTO {

        public string Titre { get; set; }
        public byte[]? Photo { get; set; }
        public string Description { get; set; }

    }
}
