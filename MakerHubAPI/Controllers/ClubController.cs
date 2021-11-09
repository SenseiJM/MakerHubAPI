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
    public class ClubController : ControllerBase {

        private ClubService cService;

        public int CurrentSeason { get; set; }

        public ClubController(ClubService clubService) {
            this.cService = clubService;
            CurrentSeason = cService.GetCurrentSeason();
        }

        [HttpGet("clubs")]
        public IActionResult GetAllClubs() {
            return Ok(cService.GetAllClubs(CurrentSeason));
        }

        [HttpGet("clubs/{index}")]
        public IActionResult GetClubByIndex(string index) {
            return Ok(cService.GetClubByIndex(index, CurrentSeason));
        }

        [HttpGet("members")]
        public IActionResult GetClubMembers() {
            return Ok(cService.GetMembers(CurrentSeason));
        }

        [HttpGet("teams")]
        public IActionResult GetClubTeams() {
            return Ok(cService.GetTeams(CurrentSeason));
        }

    }
}
