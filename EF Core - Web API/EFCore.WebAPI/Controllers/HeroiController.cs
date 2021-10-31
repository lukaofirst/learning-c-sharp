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
    public class HeroiController : ControllerBase {
        private readonly IEFCoreRepository _repo;
        public HeroiController(IEFCoreRepository repo) {
            _repo = repo;
        }

        // GET: api/<HeroiController>
        [HttpGet]
        public async Task<IActionResult> Get() {
            try {
                var heroi = await _repo.GetAllHerois(true);

                return Ok(heroi);
            } catch (Exception ex) {
                return BadRequest($"Erro: {ex.Message}");
            }
        }

        // GET api/<HeroiController>/5
        [HttpGet("{id}", Name = "GetHeroi")]
        public async Task<IActionResult> Get(int id) {
            try {
                var heroi = await _repo.GetHeroiById(id, true);

                return Ok(heroi);
            } catch (Exception ex) {

                return BadRequest($"Erro: {ex.Message}");
            }
        }

        // POST api/<HeroiController>
        [HttpPost]
        public async Task<IActionResult> Post(Heroi model) {
            try {
                _repo.Add(model);

                if(await _repo.SaveChangeAsync()) {
                    return Ok("Heroi adicionado");
                }

            } catch (Exception ex) {
                return BadRequest($"Erro: {ex.Message}");
            }

            return BadRequest("Heroi não adicionado");
        }

        // PUT api/<HeroiController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, Heroi model) {
            try {
                var heroi = await _repo.GetHeroiById(id);

                if (heroi != null) {
                    _repo.Update(model);

                    if(await _repo.SaveChangeAsync()) {
                        return Ok("Heroi atualizado");
                    }
                }

            } catch (Exception ex) {
                return BadRequest($"Erro: {ex.Message}");
            }

            return BadRequest("Heroi não atualizado");
        }

        // DELETE api/<HeroiController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id, Heroi model) {
            try {
                var heroi = await _repo.GetHeroiById(id);

                if (heroi != null) {
                    _repo.Delete(model);

                    if (await _repo.SaveChangeAsync()) {
                        return Ok("Heroi deletado");
                    }
                }

            } catch (Exception ex) {
                return BadRequest($"Erro: {ex.Message}");
            }

            return BadRequest("Heroi não deletado");
        }
    }
}
