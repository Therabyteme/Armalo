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
    public class PublicidadsController : ControllerBase
    {
        private readonly ArmaloContext _context;

        public PublicidadsController(ArmaloContext context)
        {
            _context = context;
        }

        // GET: api/Publicidads
        [HttpGet]
        public IEnumerable<Publicidad> GetPublicidad()
        {
            return _context.Publicidad;
        }

        // GET: api/Publicidads/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetPublicidad([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var publicidad = await _context.Publicidad.FindAsync(id);

            if (publicidad == null)
            {
                return NotFound();
            }

            return Ok(publicidad);
        }

        // PUT: api/Publicidads/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPublicidad([FromRoute] int id, [FromBody] Publicidad publicidad)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != publicidad.Id)
            {
                return BadRequest();
            }

            _context.Entry(publicidad).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PublicidadExists(id))
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

        // POST: api/Publicidads
        [HttpPost]
        public async Task<IActionResult> PostPublicidad([FromBody] Publicidad publicidad)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Publicidad.Add(publicidad);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPublicidad", new { id = publicidad.Id }, publicidad);
        }

        // DELETE: api/Publicidads/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePublicidad([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var publicidad = await _context.Publicidad.FindAsync(id);
            if (publicidad == null)
            {
                return NotFound();
            }

            _context.Publicidad.Remove(publicidad);
            await _context.SaveChangesAsync();

            return Ok(publicidad);
        }

        private bool PublicidadExists(int id)
        {
            return _context.Publicidad.Any(e => e.Id == id);
        }
    }
}