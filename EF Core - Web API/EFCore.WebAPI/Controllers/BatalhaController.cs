using EFCore.Dominio;
using EFCore.Repo;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCore.WebAPI.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class BatalhaController : ControllerBase {
        public readonly HeroiContext _context;
        public BatalhaController(HeroiContext context) {
            _context = context;
        }

        // GET: api/<BatalhaController>
        [HttpGet]
        public ActionResult Get() {
            try {

                return Ok(new Batalha());
            } catch (Exception ex) {

                return BadRequest($"Erro: {ex.Message}");
            }
        }

        // GET api/<BatalhaController>/5
        [HttpGet("{id}", Name = "GetBatalha")]
        public string Get(int id) {
            return "value";
        }

        // POST api/<BatalhaController>
        [HttpPost]
        public ActionResult Post(Batalha model) {
            try {
                _context.Add(model);
                _context.SaveChanges();

                return Ok("A batalha deu bom");
            } catch (Exception ex) {

                return BadRequest($"{ex.Message}");
            }
        }

        // PUT api/<BatalhaController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, Batalha model) {
            try {
                if (_context.Batalhas
                    .AsNoTracking()
                    .FirstOrDefault(b => b.Id == id) != null) 
                {
                    _context.Update(model);
                    _context.SaveChanges();

                    return Ok("Deu bom");
                }

                return Ok("Não Encontrado!");

            } catch (Exception ex) {

                return BadRequest($"{ex.Message}");
            }
        }

        // DELETE api/<BatalhaController>/5
        [HttpDelete("{id}")]
        public void Delete(int id) {
        }
    }
}
