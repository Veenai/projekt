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
    public class PizzeriaController : ControllerBase
    {
        private IPizzeriaService _pizzeriaService;

        public PizzeriaController(IPizzeriaService pizzeriaService)
        {
            _pizzeriaService = pizzeriaService;
        }

        [HttpGet]
        [Produces(typeof(List<Pizzeria>))]
        public IActionResult GetAllPizzerias()
        {
            var pizzerias = _pizzeriaService.Get();
            return Ok(pizzerias);
        }

        [HttpPost]
        [Produces(typeof(int))]
        public IActionResult Post([FromBody] Pizzeria pizzeria)
        {
            int id = _pizzeriaService.Post(pizzeria);

            return Ok(id);
        }

        [HttpPut]
        [Route("{id}")]
        public IActionResult Put([FromRoute] int id, [FromBody] Pizzeria pizzeria)
        {
            if (id != pizzeria.Id)
            {
                return Conflict("Podane id są różne");
            }

            var isUpdateSuccesfull = _pizzeriaService.Put(id, pizzeria);

            if (isUpdateSuccesfull)
                return NoContent();

            return NotFound();
        }

        [HttpDelete]
        [Route("{id}")]
        public IActionResult Delete([FromRoute] int id)
        {
            var result = _pizzeriaService.Delete(id);
            if (result)
                return NoContent();

            return NotFound();
        }

    }
}
