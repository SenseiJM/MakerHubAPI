using MakerHubAPI.DAL.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MakerHubAPI.DTO {
    public class JoueurIndexDTO {

        public int ID { get; set; }
        public int IDAFTT { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string ClassementHommes { get; set; }
        public string? ClassementDames { get; set; }

    }
}
