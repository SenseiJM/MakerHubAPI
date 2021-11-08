using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MakerHubAPI.DTO.Team {
    public class TeamIndexDTO {

        public string TeamId { get; set; }
        public char Team { get; set; }
        public int DivisionId { get; set; }
        public string DivisionName { get; set; }
        public string DivisionCategory { get; set; }

    }
}
