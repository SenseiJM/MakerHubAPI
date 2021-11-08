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

        public ClubController(ClubService clubService) {
            this.cService = clubService;
        }

        [HttpGet("clubs")]
        public IActionResult GetAllClubs() {
            return Ok(cService.GetAllClubs());
        }

        [HttpGet("clubs/{index}")]
        public IActionResult GetClubByIndex(string index) {
            return Ok(cService.GetClubByIndex(index, 22));
        }

        [HttpGet("members")]
        public IActionResult GetClubMembers() {
            return Ok(cService.GetMembers(22));
        }

    }
}
