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

        [HttpGet]
        public IActionResult GetAllClubs() {
            return Ok(cService.Get());
        }

    }
}
