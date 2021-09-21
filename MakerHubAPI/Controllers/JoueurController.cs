using MakerHubAPI.DTO;
using MakerHubAPI.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MakerHubAPI.Controllers {

    [Route("api/[controller]")]
    [ApiController]
    public class JoueurController : ControllerBase {

        private JoueurService jService;

        public JoueurController(JoueurService jService) {
            this.jService = jService;
        }

        [HttpPost]
        public IActionResult AddJoueur(JoueurAddDTO dto) {

            jService.Create(dto);
            return NoContent();

        }

        [HttpGet("byID/{id}")]
        public IActionResult GetOneByID(int id) {
            return Ok(jService.GetByID(id));
        }

        [HttpGet("byName/{name}")]
        public IActionResult GetAllByName(string name) {
            return Ok(jService.GetAllByName(name));
        }

        [HttpGet]
        public IActionResult GetAll() {
            return Ok(jService.GetAll());
        }

        [HttpPut("{id}")]
        public IActionResult Update(JoueurDetailsDTO dto, int id) {
            jService.Update(dto, id);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id) {
            jService.Delete(id);
            return NoContent();
        }

    }
}
