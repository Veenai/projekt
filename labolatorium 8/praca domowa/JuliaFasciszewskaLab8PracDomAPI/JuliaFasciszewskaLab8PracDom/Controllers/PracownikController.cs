using JuliaFasciszewskaLab8PracDom.Models;
using JuliaFasciszewskaLab8PracDom.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JuliaFasciszewskaLab8PracDom.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PracownikController : ControllerBase
    {
        private IPracownikService _pracownikService;

        public PracownikController(IPracownikService pracownikService)
        {
            _pracownikService = pracownikService;
        }

        [HttpGet]
        [Produces(typeof(List<Pracownik>))]
        public IActionResult GetAllPracowniks()
        {
            var pracowniks = _pracownikService.Get();
            return Ok(pracowniks);
        }

        [HttpPost]
        [Produces(typeof(int))]
        public IActionResult Post([FromBody] Pracownik pracownik)
        {
            int id = _pracownikService.Post(pracownik);

            return Ok(id);
        }

        [HttpPut]
        [Route("{id}")]
        public IActionResult Put([FromRoute] int id, [FromBody] Pracownik pracownik)
        {
            if (id != pracownik.Id)
            {
                return Conflict("Podane id są różne");
            }

            var isUpdateSuccesfull = _pracownikService.Put(id, pracownik);

            if (isUpdateSuccesfull)
                return NoContent();

            return NotFound();
        }

        [HttpDelete]
        [Route("{id}")]
        public IActionResult Delete([FromRoute] int id)
        {
            var result = _pracownikService.Delete(id);
            if (result)
                return NoContent();

            return NotFound();
        }

    }
}
