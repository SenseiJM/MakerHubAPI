using MakerHubAPI.DTO.Annonce;
using MakerHubAPI.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MakerHubAPI.Controllers {

    [Route("api/[controller]")]
    [ApiController]
    public class AnnonceController : ControllerBase {

        private AnnonceService aService;

        public AnnonceController(AnnonceService aService) {
            this.aService = aService;
        }

        [HttpPost]
        public IActionResult AddAnnonce(AnnonceAddDTO dto) {
            aService.Create(dto);
            return NoContent();
        }

        [HttpGet("byID/{id}")]
        public IActionResult GetByID(int id) {
            return Ok(aService.GetByID(id));
        }

        [HttpGet("byTitle/{titre}")]
        public IActionResult GetAllByTitre(string titre) {
            return Ok(aService.GetAllByTitle(titre));
        }

        [HttpGet]
        public IActionResult GetAll() {
            return Ok(aService.GetAll());
        }

        [HttpPut("{id}")]
        public IActionResult Update(AnnonceDetailsDTO dto, int id) {
            aService.Update(dto, id);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id) {
            aService.Delete(id);
            return NoContent();
        }

        [HttpGet("image/{id}")]
        public IActionResult GetImage(int id) {

            AnnonceDetailsDTO dto = aService.GetByID(id);

            if(dto?.Photo == null) {
                return NotFound();
            }

            return File(dto.Photo, "image/png");
        }

    }
}
