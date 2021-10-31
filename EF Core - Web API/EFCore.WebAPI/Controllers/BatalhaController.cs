﻿using EFCore.Dominio;
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
        private readonly IEFCoreRepository _repo;
        public BatalhaController(IEFCoreRepository repo) {
            _repo = repo;
        }

        // GET: api/<BatalhaController>
        [HttpGet]
        public async Task<IActionResult> Get() {
            try {
                var batalhas = await _repo.GetAllBatalhas(true);

                return Ok(batalhas);
            } catch (Exception ex) {

                return BadRequest($"Erro: {ex.Message}");
            }
        }

        // GET api/<BatalhaController>/5
        [HttpGet("{id}", Name = "GetBatalha")]
        public async Task<IActionResult> Get(int id) {
            try {
                var batalha = await _repo.GetBatalhaById(id, true);

                return Ok(batalha);
            } catch (Exception ex) {

                return BadRequest($"Erro: {ex.Message}");
            }
        }

        // POST api/<BatalhaController>
        [HttpPost]
        public async Task<IActionResult> Post(Batalha model) {
            try {
                _repo.Add(model);

                if(await _repo.SaveChangeAsync()) {
                    return Ok("Batalha adicionada");
                }

            } catch (Exception ex) {

                return BadRequest($"{ex.Message}");
            }

            return BadRequest("Batalha não adicionada :(");
        }

        // PUT api/<BatalhaController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, Batalha model) {
            try {
                var batalha = await _repo.GetBatalhaById(id);
                if (batalha != null) {

                    _repo.Update(model);

                    if (await _repo.SaveChangeAsync())
                        return Ok("Batalha atualizada");
                }


            } catch (Exception ex) {

                return BadRequest($"{ex.Message}");
            }

            return BadRequest("Batalha não atualizada");
        }

        // DELETE api/<BatalhaController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id) {
            try {
                var batalha = await _repo.GetBatalhaById(id);

                if (batalha != null) {

                    _repo.Delete(batalha);

                    if (await _repo.SaveChangeAsync())
                        return Ok("Batalha deletada");
                }

            } catch (Exception ex) {

                return BadRequest($"{ex.Message}");
            }

            return BadRequest("Batalha não deletada");
        }
    }
}
