using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MakerHubAPI.DTO.Season {
    public class SeasonDetailsDTO {

        public int Season { get; set; }
        public string Name { get; set; }
        public bool IsCurrent { get; set; }

    }
}
