using MakerHubAPI.DTO.Souper;
using MakerHubAPI.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MakerHubAPI.Controllers {

    [Route("api/[controller]")]
    [ApiController]
    public class SouperController : ControllerBase {

        private SouperService sService;

        public SouperController(SouperService sService) {
            this.sService = sService;
        }

        [HttpPost]
        public IActionResult AddSouper(SouperAddDTO dto) {
            sService.Create(dto);
            return NoContent();
        }

        [HttpGet("byID/{id}")]
        public IActionResult GetByID(int id) {
            return Ok(sService.GetByID(id));
        }

        [HttpGet]
        public IActionResult GetAll() {
            return Ok(sService.GetAll());
        }

        [HttpPut("{id}")]
        public IActionResult Update(SouperDetailsDTO dto, int id) {
            sService.Update(dto, id);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id) {
            sService.Delete(id);
            return NoContent();
        }
    }
}
