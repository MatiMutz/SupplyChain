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
    public class VendeController : ControllerBase
    {
        private readonly AppDbContext _context;

        public VendeController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Areas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Vende>>> GetUnidades()
        {
            return await _context.Vendes.ToListAsync();
        }

        // GET: api/Areas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Vende>> GetUnidad(int id)
        {
            var vende = await _context.Vendes.FindAsync(id);

            if (vende == null)
            {
                return NotFound();
            }

            return vende;
        }

        // PUT: api/Unidades/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUnidad(int id, Vende vende)
        {
            if (id != vende.CG_VEN)
            {
                return BadRequest();
            }

            _context.Entry(vende).State = EntityState.Modified;

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
        public async Task<ActionResult<Vende>> PostUnidad(Vende vende)
        {
            _context.Vendes.Add(vende);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (UnidadExists(vende.CG_VEN))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetUnidad", new { id = vende.CG_VEN }, vende);
        }

        // DELETE: api/Unidades/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Vende>> DeleteUnidad(int id)
        {
            var vende = await _context.Vendes.FindAsync(id);
            if (vende == null)
            {
                return NotFound();
            }

            _context.Vendes.Remove(vende);
            await _context.SaveChangesAsync();

            return vende;
        }

        private bool UnidadExists(int id)
        {
            return _context.Vendes.Any(e => e.CG_VEN == id);
        }
    }
}
