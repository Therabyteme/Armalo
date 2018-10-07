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
    public class HistoriaDeEventosOrgsController : ControllerBase
    {
        private readonly ArmaloContext _context;

        public HistoriaDeEventosOrgsController(ArmaloContext context)
        {
            _context = context;
        }

        // GET: api/HistoriaDeEventosOrgs
        [HttpGet]
        public IEnumerable<HistoriaDeEventosOrg> GetHistoriaDeEventosOrg()
        {
            return _context.HistoriaDeEventosOrg;
        }

        // GET: api/HistoriaDeEventosOrgs/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetHistoriaDeEventosOrg([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var historiaDeEventosOrg = await _context.HistoriaDeEventosOrg.FindAsync(id);

            if (historiaDeEventosOrg == null)
            {
                return NotFound();
            }

            return Ok(historiaDeEventosOrg);
        }

        // PUT: api/HistoriaDeEventosOrgs/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHistoriaDeEventosOrg([FromRoute] int id, [FromBody] HistoriaDeEventosOrg historiaDeEventosOrg)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != historiaDeEventosOrg.IdOrg)
            {
                return BadRequest();
            }

            _context.Entry(historiaDeEventosOrg).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HistoriaDeEventosOrgExists(id))
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

        // POST: api/HistoriaDeEventosOrgs
        [HttpPost]
        public async Task<IActionResult> PostHistoriaDeEventosOrg([FromBody] HistoriaDeEventosOrg historiaDeEventosOrg)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.HistoriaDeEventosOrg.Add(historiaDeEventosOrg);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetHistoriaDeEventosOrg", new { id = historiaDeEventosOrg.IdOrg }, historiaDeEventosOrg);
        }

        // DELETE: api/HistoriaDeEventosOrgs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHistoriaDeEventosOrg([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var historiaDeEventosOrg = await _context.HistoriaDeEventosOrg.FindAsync(id);
            if (historiaDeEventosOrg == null)
            {
                return NotFound();
            }

            _context.HistoriaDeEventosOrg.Remove(historiaDeEventosOrg);
            await _context.SaveChangesAsync();

            return Ok(historiaDeEventosOrg);
        }

        private bool HistoriaDeEventosOrgExists(int id)
        {
            return _context.HistoriaDeEventosOrg.Any(e => e.IdOrg == id);
        }
    }
}