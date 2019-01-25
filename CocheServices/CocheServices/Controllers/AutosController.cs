using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CocheServices.Model.CochebDb;
using CocheServices.Model.Repositories;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CocheServices.Controllers
{
    [Route("api/[controller]")]
    public class AutosController : Controller
    {
        private IProyectoRepository repositorio;
        public AutosController(IProyectoRepository repo)
        {
            repositorio = repo;
        }
        // GET: api/<controller>
        [HttpGet]
        public IQueryable<TCoche> Get()
        {
            return repositorio.Items;
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public TCoche Get(Guid ProyectoId)
        {
            return repositorio.Items.Where(p => p.CocheId == ProyectoId).FirstOrDefault();
        }

        // POST api/<controller>
        [HttpPost]
        public IActionResult Post([FromBody]TCoche proyecto)
        {
            repositorio.Save(proyecto);
            return Ok(true);
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
