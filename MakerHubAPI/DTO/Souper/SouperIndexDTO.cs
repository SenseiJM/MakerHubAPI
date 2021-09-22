using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MakerHubAPI.DTO.Souper {
    public class SouperIndexDTO {

        public string Titre { get; set; }
        public byte[]? Photo { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }

    }
}
