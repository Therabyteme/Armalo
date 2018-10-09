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
    [Route("api/evento")]
    [ApiController]
    public class Database : ControllerBase
    {
        private readonly ArmaloContext _context;

        public Database(ArmaloContext context)
        {
            _context = context;
        }

       

        // GET: api/Eventos
        [HttpGet]
        public IEnumerable<Evento> GetEvento(string nombre, string precio)
        {
            if (!String.IsNullOrEmpty(nombre))
            {
                _context.Evento.Where(s=>s.Nombre.Contains(nombre));
            }
            if(!String.IsNullOrEmpty(precio))
            {
                _context.Evento.Where(s => s.Precio.Equals(precio));
            }
            return _context.Evento
                .Include(e => e.EventoTags)
                .Include(e => e.AgendaNavigation)
                .Include(e => e.retroAlimentaciones).ToList();
        }

        // GET: api/Eventos/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetEvento([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var evento = await _context.Evento.FindAsync(id);

            if (evento == null)
            {
                return NotFound();
            }

            return Ok(evento);
        }

        // PUT: api/Eventos/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEvento([FromRoute] int id, [FromBody] Evento evento)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != evento.IdEvent)
            {
                return BadRequest();
            }

            _context.Entry(evento).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EventoExists(id))
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

        // PUT: api/Eventos/5/feedback
        [HttpPost("{id}/feedback")]
        public async Task<IActionResult> Feedback([FromRoute] int id, [FromBody] RetroAlimentacion feedback)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            

            _context.Entry(feedback).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EventoExists(id))
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

        // POST: api/Eventos
        [HttpPost]
        public async Task<IActionResult> PostEvento([FromBody] Evento evento)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Evento.Add(evento);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEvento", new { id = evento.IdEvent }, evento);
        }

        // DELETE: api/Eventos/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEvento([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var evento = await _context.Evento.FindAsync(id);
            if (evento == null)
            {
                return NotFound();
            }

            _context.Evento.Remove(evento);
            await _context.SaveChangesAsync();

            return Ok(evento);
        }

        private bool EventoExists(int id)
        {
            return _context.Evento.Any(e => e.IdEvent == id);
        }
    }
}