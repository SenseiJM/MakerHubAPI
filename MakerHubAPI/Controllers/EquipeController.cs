using MakerHubAPI.DTO.Equipe;
using MakerHubAPI.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MakerHubAPI.Controllers {

    [Route("api/[controller]")]
    [ApiController]
    public class EquipeController : ControllerBase {

        private EquipeService eService;

        public EquipeController(EquipeService eService) {
            this.eService = eService;
        }

        [HttpPost]
        public IActionResult AddEquipe(EquipeAddDTO dto) {
            eService.Create(dto);
            return NoContent();
        }

        [HttpGet("byID/{id}")]
        public IActionResult GetOneByID(int id) {
            return Ok(eService.GetByID(id));
        }

        [HttpGet("byName/{name}")]
        public IActionResult GetAllByName(string name) {
            return Ok(eService.GetAllByName(name));
        }

        [HttpGet]
        public IActionResult GetAll() {
            return Ok(eService.GetAll());
        }

        [HttpPut("{id}")]
        public IActionResult Update(EquipeDetailsDTO dto, int id) {
            eService.Update(dto, id);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id) {
            eService.Delete(id);
            return NoContent();
        }
    }
}
