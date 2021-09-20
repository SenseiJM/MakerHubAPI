using MakerHubAPI.DTO.Classement;
using MakerHubAPI.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MakerHubAPI.Controllers {

    [Route("api/[controller]")]
    [ApiController]
    public class ClassementController : ControllerBase {

        private ClassementService cService;

        public ClassementController(ClassementService cService) {
            this.cService = cService;
        }

        [HttpPost]
        public IActionResult AddClassement(ClassementAddDTO dto) {
            cService.Create(dto);
            return NoContent();
        }

        [HttpGet("byID/{id}"]
        public IActionResult GetByID(int id) {
            return Ok(cService.GetByID(id));
        }

        [HttpGet]
        public IActionResult GetAll() {
            return Ok(cService.GetAll());
        }

        [HttpPut("{id}")]
        public IActionResult Update(ClassementDetailsDTO dto, int id) {
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
