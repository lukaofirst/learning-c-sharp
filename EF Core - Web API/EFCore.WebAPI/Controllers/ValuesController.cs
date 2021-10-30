using EFCore.Dominio;
using EFCore.Repo;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCore.WebAPI.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : Controller {

        public readonly HeroiContext _context;
        public ValuesController(HeroiContext context) {
            _context = context;
        }

        // GET: api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get() {
            return new string[] { "value1", "value2" };
        }

        // GET: ValuesController/Details/5
        [HttpGet("{nameHero}")]
        public ActionResult Get(string nameHero) {
            var heroi = new Heroi { Nome = nameHero };

            _context.Herois.Add(heroi);
            //contexto.Add(heroi);
            _context.SaveChanges();

            return Ok();
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value) {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value) {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id) {
        }
    }
}
