using MakerHubAPI.DTO.CategorieAge;
using MakerHubAPI.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MakerHubAPI.Controllers {
    public class CategorieAgeController : ControllerBase {

        private CategorieAgeService cService;

        public CategorieAgeController(CategorieAgeService cService) {
            this.cService = cService;
        }

        [HttpPost]
        public IActionResult AddCategorieAge(CategorieAgeAddDTO dto) {
            cService.Create(dto);
            return NoContent();
        }

        [HttpGet("byID/{id}")]
        public IActionResult GetOneByID(int id) {
            return Ok(cService.GetByID(id));
        }

        [HttpGet("byName/{name}")]
        public IActionResult GetAllByName(string name) {
            return Ok(cService.GetAllByName(name));
        }

        [HttpGet]
        public IActionResult GetAll() {
            return Ok(cService.GetAll());
        }

        [HttpPut("{id}")]
        public IActionResult Update(CategorieAgeDetailsDTO dto, int id) {
            cService.Update(dto, id);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id) {
            cService.Delete(id);
            return NoContent();
        }
    }
}
