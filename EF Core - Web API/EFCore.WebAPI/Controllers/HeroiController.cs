using EFCore.Dominio;
using EFCore.Repo;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCore.WebAPI.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class HeroiController : ControllerBase {
        private readonly HeroiContext _context;
        public HeroiController(HeroiContext context) {
            _context = context;
        }

        // GET: api/<HeroiController>
        [HttpGet]
        public ActionResult Get() {
            try {


                return Ok();
            } catch (Exception ex) {
                return BadRequest($"Erro: {ex.Message}");
            }
        }

        // GET api/<HeroiController>/5
        [HttpGet("{id}", Name = "GET")]
        public ActionResult Get(int id) {
            return Ok("value");
        }

        // POST api/<HeroiController>
        [HttpPost]
        public ActionResult Post() {
            try {
                var heroi = new Heroi {
                    Nome = "Homem de Ferro",
                    Armas = new List<Arma> {
                        new Arma { Nome = "Mac 5" },
                        new Arma { Nome = "Mac 3" },
                    }
                };

                _context.Herois.Add(heroi);
                _context.SaveChanges();

                return Ok("Deu bom");
            } catch (Exception ex) {
                return BadRequest($"Erro: {ex.Message}");
            }
        }

        // PUT api/<HeroiController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id) {
            try {
                var heroi = new Heroi {
                    Id = id,
                    Nome = "Iron Man",
                    Armas = new List<Arma> {
                        new Arma { Id = 3, Nome = "Mark III" },
                        new Arma { Id = 4, Nome = "Mark V" },
                    }
                };

                _context.Update(heroi);
                _context.SaveChanges();

                return Ok("Deu bom");
            } catch (Exception ex) {
                return BadRequest($"Erro: {ex.Message}");
            }
        }

        // DELETE api/<HeroiController>/5
        [HttpDelete("{id}")]
        public void Delete(int id) {
        }
    }
}
