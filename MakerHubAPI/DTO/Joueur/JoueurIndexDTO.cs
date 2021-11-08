using MakerHubAPI.DAL.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MakerHubAPI.DTO {
    public class JoueurIndexDTO {

        public int ID { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public int IDClassementHommes { get; set; }
        public Classements ClassementHommes { get; set; }
        public int? IDClassementDames { get; set; }
        public Classements? ClassementDames { get; set; }

    }
}
