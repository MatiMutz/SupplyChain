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
    public class ClasesController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ClasesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Clases
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Clase>>> GetClases()
        {
            return await _context.Clases.ToListAsync();
        }

        // GET: api/Clases/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Clase>> GetClases(int id)
        {
            var Clases = await _context.Clases.FindAsync(id);

            if (Clases == null)
            {
                return NotFound();
            }

            return Clases;
        }

        // PUT: api/Clases/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutClases(int id, Clase Clases)
        {
            if (id != Clases.CG_CLASE)
            {
                return BadRequest();
            }

            _context.Entry(Clases).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ClasesExists(id))
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

        // POST: api/Clases
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Clase>> PostClases(Clase Clases)
        {
            _context.Clases.Add(Clases);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ClasesExists(Clases.CG_CLASE))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetClases", new { id = Clases.CG_CLASE }, Clases);
        }

        // DELETE: api/Clases/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Clase>> DeleteClases(int id)
        {
            var Clases = await _context.Clases.FindAsync(id);
            if (Clases == null)
            {
                return NotFound();
            }

            _context.Clases.Remove(Clases);
            await _context.SaveChangesAsync();

            return Clases;
        }

        private bool ClasesExists(int id)
        {
            return _context.Clases.Any(e => e.CG_CLASE == id);
        }
    }
}