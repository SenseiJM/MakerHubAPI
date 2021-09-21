using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MakerHubAPI.DTO.Equipe {
    public class EquipeDetailsDTO {

        public string Nom { get; set; }
        public int IDCategorieInterclubs { get; set; }
        public string LieuMatch { get; set; }
        public TimeSpan HeureMatch { get; set; }
        public TimeSpan? HeureDepart { get; set; }
        public string Division { get; set; }

    }
}
