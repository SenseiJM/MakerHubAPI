using MakerHubAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MakerHubAPI.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class MatchesController : ControllerBase {

        private MatchService mService;
        private ClubService cService;

        public int CurrentSeason { get; set; }

        public MatchesController(MatchService mService, ClubService cService) {
            this.mService = mService;
            this.cService = cService;
            CurrentSeason = cService.GetCurrentSeason();
        }

        [HttpGet("matches")]
        public IActionResult GetMatchesByTeam(char TeamLetter) {
            return Ok(mService.GetMatchesByTeam(TeamLetter, CurrentSeason));
        }
    }
}
