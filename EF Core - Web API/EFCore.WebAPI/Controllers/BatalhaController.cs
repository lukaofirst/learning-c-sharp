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
        private IEFCoreRepository _repo { get; set; }
        public BatalhaController(IEFCoreRepository repo) {
            _repo = repo;
        }

        // GET: api/<BatalhaController>
        [HttpGet]
        public async Task<IActionResult> Get() {
            try {
                var herois = await _repo.GetAllHerois();

                return Ok(herois);
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
        public async Task<IActionResult> Post(Batalha model) {
            try {
                _repo.Add(model);

                if(await _repo.SaveChangeAsync()) {
                    return Ok("A batalha deu bom");
                }

            } catch (Exception ex) {

                return BadRequest($"{ex.Message}");
            }

            return BadRequest("Não salvou :(");
        }

        // PUT api/<BatalhaController>/5
        /*[HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, Batalha model) {
            try {
                if (_repo
                    .AsNoTracking()
                    .FirstOrDefault(b => b.Id == id) != null) 
                {
                    _repo.Update(model);

                    if(await _repo.SaveChangeAsync()) {
                        return Ok("Registro de batalha atualizado");
                    }

                    return Ok("Deu bom");
                }

                return Ok("Não Encontrado!");

            } catch (Exception ex) {

                return BadRequest($"{ex.Message}");
            }
        }*/

        // DELETE api/<BatalhaController>/5
        [HttpDelete("{id}")]
        public void Delete(int id) {
            /*try {
                _repo.Delete(model);

                if (await _repo.SaveChangeAsync()) {
                    return Ok("A batalha deu bom");
                }

            } catch (Exception ex) {

                return BadRequest($"{ex.Message}");
            }

            return BadRequest("Não salvou :(");*/
        }
    }
}
