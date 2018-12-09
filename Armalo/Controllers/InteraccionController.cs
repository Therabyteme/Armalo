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
    public class InteraccionController : ControllerBase
    {
        private readonly ArmaloContext _context;

        public InteraccionController(ArmaloContext context)
        {
            _context = context;
        }

        // GET: api/Interaccion
        [HttpGet]
        public IEnumerable<Interaccion> GetInteraccion()
        {
            return _context.Interaccion;
        }

        // GET: api/Interaccion/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetInteraccion([FromRoute] int? id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var interaccion = await _context.Interaccion.FindAsync(id);

            if (interaccion == null)
            {
                return NotFound();
            }

            return Ok(interaccion);
        }

        // PUT: api/Interaccion/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutInteraccion([FromRoute] int? id, [FromBody] Interaccion interaccion)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != interaccion.idinteraccion)
            {
                return BadRequest();
            }

            _context.Entry(interaccion).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InteraccionExists(id))
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

        // POST: api/Interaccion
        [HttpPost]
        public async Task<IActionResult> PostInteraccion([FromBody] Interaccion interaccion)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Interaccion.Add(interaccion);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetInteraccion", new { idinteraccion = interaccion.idinteraccion }, interaccion);
        }

        // DELETE: api/Interaccion/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteInteraccion([FromRoute] int? id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var interaccion = await _context.Interaccion.FindAsync(id);
            if (interaccion == null)
            {
                return NotFound();
            }

            _context.Interaccion.Remove(interaccion);
            await _context.SaveChangesAsync();

            return Ok(interaccion);
        }

        private bool InteraccionExists(int? id)
        {
            return _context.Interaccion.Any(e => e.idinteraccion == id);
        }
    }
}