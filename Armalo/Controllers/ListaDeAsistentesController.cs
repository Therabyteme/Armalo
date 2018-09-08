using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Armalo.Models;

namespace Armalo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ListaDeAsistentesController : ControllerBase
    {
        private readonly ArmaloContext _context;

        public ListaDeAsistentesController(ArmaloContext context)
        {
            _context = context;
        }

        // GET: api/ListaDeAsistentes
        [HttpGet]
        public IEnumerable<ListaDeAsistentes> GetListaDeAsistentes()
        {
            return _context.ListaDeAsistentes;
        }

        // GET: api/ListaDeAsistentes/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetListaDeAsistentes([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var listaDeAsistentes = await _context.ListaDeAsistentes.FindAsync(id);

            if (listaDeAsistentes == null)
            {
                return NotFound();
            }

            return Ok(listaDeAsistentes);
        }

        // PUT: api/ListaDeAsistentes/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutListaDeAsistentes([FromRoute] int id, [FromBody] ListaDeAsistentes listaDeAsistentes)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != listaDeAsistentes.IdLista)
            {
                return BadRequest();
            }

            _context.Entry(listaDeAsistentes).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ListaDeAsistentesExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/ListaDeAsistentes
        [HttpPost]
        public async Task<IActionResult> PostListaDeAsistentes([FromBody] ListaDeAsistentes listaDeAsistentes)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.ListaDeAsistentes.Add(listaDeAsistentes);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetListaDeAsistentes", new { id = listaDeAsistentes.IdLista }, listaDeAsistentes);
        }

        // DELETE: api/ListaDeAsistentes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteListaDeAsistentes([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var listaDeAsistentes = await _context.ListaDeAsistentes.FindAsync(id);
            if (listaDeAsistentes == null)
            {
                return NotFound();
            }

            _context.ListaDeAsistentes.Remove(listaDeAsistentes);
            await _context.SaveChangesAsync();

            return Ok(listaDeAsistentes);
        }

        private bool ListaDeAsistentesExists(int id)
        {
            return _context.ListaDeAsistentes.Any(e => e.IdLista == id);
        }
    }
}