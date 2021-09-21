using MakerHubAPI.DTO.CategorieInterclubs;
using MakerHubAPI.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MakerHubAPI.Controllers {

    [Route("api/[controller]")]
    [ApiController]
    public class CategorieInterclubsController : ControllerBase {

        private CategorieInterclubsService cService;

        public CategorieInterclubsController(CategorieInterclubsService cService) {
            this.cService = cService;
        }

        [HttpPost]
        public IActionResult AddCategorieInterclubs(CategorieInterclubsAddDTO dto) {
            cService.Create(dto);
            return NoContent();
        }

        [HttpGet("ByID/{id}")]
        public IActionResult GetOneByID(int id) {
            return Ok(cService.GetByID(id));
        }

        [HttpGet]
        public IActionResult GetAll() {
            return Ok(cService.GetAll());
        }

        [HttpPut("{id}")]
        public IActionResult Update(CategorieInterclubsDetailsDTO dto, int id) {
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
