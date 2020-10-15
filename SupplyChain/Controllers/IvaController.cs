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
    public class IvaController : ControllerBase
    {
        private readonly AppDbContext _context;

        public IvaController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Areas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Iva>>> GetUnidades()
        {
            return await _context.Ivas.ToListAsync();
        }

        // GET: api/Areas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Iva>> GetUnidad(string id)
        {
            var iva = await _context.Ivas.FindAsync(id);

            if (iva == null)
            {
                return NotFound();
            }

            return iva;
        }

        // PUT: api/Unidades/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUnidad(string id, Iva iva)
        {
            if (id != iva.CG_COND)
            {
                return BadRequest();
            }

            _context.Entry(iva).State = EntityState.Modified;

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
        public async Task<ActionResult<Iva>> PostUnidad(Iva iva)
        {
            _context.Ivas.Add(iva);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (UnidadExists(iva.CG_COND))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetUnidad", new { id = iva.CG_COND }, iva);
        }

        // DELETE: api/Unidades/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Iva>> DeleteUnidad(string id)
        {
            var iva = await _context.Ivas.FindAsync(id);
            if (iva == null)
            {
                return NotFound();
            }

            _context.Ivas.Remove(iva);
            await _context.SaveChangesAsync();

            return iva;
        }

        private bool UnidadExists(string id)
        {
            return _context.Ivas.Any(e => e.CG_COND == id);
        }
    }
}
