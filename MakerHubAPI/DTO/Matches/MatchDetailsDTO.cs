using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MakerHubAPI.DTO.Matches {
    public class MatchDetailsDTO {
        public string MatchID { get; set; }
        public string WeekName { get; set; }
        public DateTime Date { get; set; }
        public string Time { get; set; }
        public string HomeClub { get; set; }
        public string HomeTeam { get; set; }
        public string AwayClub { get; set; }
        public string AwayTeam { get; set; }
        public string Score { get; set; }
        public int MatchUniqueId { get; set; }
        public bool IsHomeForfeited { get; set; }
        public bool IsAwayForfeited { get; set; }

    }
}
