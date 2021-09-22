using MakerHubAPI.DTO.TypeSouper;
using MakerHubAPI.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MakerHubAPI.Controllers {

    [Route("api/[controller]")]
    [ApiController]
    public class TypeSouperController : ControllerBase {

        private TypeSouperService tService;

        public TypeSouperController(TypeSouperService tService) {
            this.tService = tService;
        }

        [HttpPost]
        public IActionResult AddTypeSouper(TypeSouperAddDTO dto) {
            tService.Create(dto);
            return NoContent();
        }

        [HttpGet("byID/{id}")]
        public IActionResult GetOneByID(int id) {
            return Ok(tService.GetByID(id));
        }

        [HttpGet]
        public IActionResult GetAll() {
            return Ok(tService.GetAll());
        }

        [HttpPut("{id}")]
        public IActionResult Update(TypeSouperDetailsDTO dto, int id) {
            tService.Update(dto, id);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id) {
            tService.Delete(id);
            return NoContent();
        }
    }
}
