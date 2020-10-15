using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SupplyChain.Server.DataAccess;
using SupplyChain.Shared.Models;

namespace SupplyChain.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CiasController : ControllerBase
    {
        private readonly AppDbContext _context;

        public CiasController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Areas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Cia>>> GetUnidades()
        {
            return await _context.Cias.ToListAsync();
        }

        // GET: api/Areas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Cia>> GetUnidad(int id)
        {
            var cia = await _context.Cias.FindAsync(id);

            if (cia == null)
            {
                return NotFound();
            }

            return cia;
        }

        // PUT: api/Unidades/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUnidad(int id, Cia cia)
        {
            if (id != cia.CG_CIA)
            {
                return BadRequest();
            }

            _context.Entry(cia).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UnidadExists(id))
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

        // POST: api/Unidades
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Cia>> PostUnidad(Cia cia)
        {
            _context.Cias.Add(cia);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (UnidadExists(cia.CG_CIA))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetUnidad", new { id = cia.CG_CIA }, cia);
        }

        // DELETE: api/Unidades/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Cia>> DeleteUnidad(int id)
        {
            var cia = await _context.Cias.FindAsync(id);
            if (cia == null)
            {
                return NotFound();
            }

            _context.Cias.Remove(cia);
            await _context.SaveChangesAsync();

            return cia;
        }

        private bool UnidadExists(int id)
        {
            return _context.Cias.Any(e => e.CG_CIA == id);
        }
    }
}
