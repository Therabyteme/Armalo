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
    public class HistoriaDeEventosUsrsController : ControllerBase
    {
        private readonly ArmaloContext _context;

        public HistoriaDeEventosUsrsController(ArmaloContext context)
        {
            _context = context;
        }

        // GET: api/HistoriaDeEventosUsrs
        [HttpGet]
        public IEnumerable<HistoriaDeEventosUsr> GetHistoriaDeEventosUsr()
        {
            return _context.HistoriaDeEventosUsr;
        }

        // GET: api/HistoriaDeEventosUsrs/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetHistoriaDeEventosUsr([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var historiaDeEventosUsr = await _context.HistoriaDeEventosUsr.FindAsync(id);

            if (historiaDeEventosUsr == null)
            {
                return NotFound();
            }

            return Ok(historiaDeEventosUsr);
        }

        // PUT: api/HistoriaDeEventosUsrs/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHistoriaDeEventosUsr([FromRoute] int id, [FromBody] HistoriaDeEventosUsr historiaDeEventosUsr)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != historiaDeEventosUsr.Id)
            {
                return BadRequest();
            }

            _context.Entry(historiaDeEventosUsr).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HistoriaDeEventosUsrExists(id))
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

        // POST: api/HistoriaDeEventosUsrs
        [HttpPost]
        public async Task<IActionResult> PostHistoriaDeEventosUsr([FromBody] HistoriaDeEventosUsr historiaDeEventosUsr)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.HistoriaDeEventosUsr.Add(historiaDeEventosUsr);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetHistoriaDeEventosUsr", new { id = historiaDeEventosUsr.Id }, historiaDeEventosUsr);
        }

        // DELETE: api/HistoriaDeEventosUsrs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHistoriaDeEventosUsr([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var historiaDeEventosUsr = await _context.HistoriaDeEventosUsr.FindAsync(id);
            if (historiaDeEventosUsr == null)
            {
                return NotFound();
            }

            _context.HistoriaDeEventosUsr.Remove(historiaDeEventosUsr);
            await _context.SaveChangesAsync();

            return Ok(historiaDeEventosUsr);
        }

        private bool HistoriaDeEventosUsrExists(int id)
        {
            return _context.HistoriaDeEventosUsr.Any(e => e.Id == id);
        }
    }
}