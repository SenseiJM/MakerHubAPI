using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MakerHubAPI.DTO.Member {
    public class MemberIndexDTO {
        public int Position { get; set; }
        public int UniqueIndex { get; set; }
        public int RankingIndex { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Ranking { get; set; }
    }
}
