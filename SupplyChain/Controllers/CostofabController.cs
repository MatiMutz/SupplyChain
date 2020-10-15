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
    public class CostofabController : ControllerBase
    {
        private readonly AppDbContext _context;

        public CostofabController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Costofab
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Costofab>>> GetCostofab()
        {
            return await _context.Costofab.ToListAsync();
        }

        // GET: api/Costofab/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Costofab>> GetCostofab(int id)
        {
            var Costofab = await _context.Costofab.FindAsync(id);

            if (Costofab == null)
            {
                return NotFound();
            }

            return Costofab;
        }

        // PUT: api/Costofab/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCostofab(int id, Costofab Costofab)
        {
            if (id != Costofab.CG_ORDF)
            {
                return BadRequest();
            }

            _context.Entry(Costofab).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CostofabExists(id))
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

        // POST: api/Costofab
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Costofab>> PostCostofab(Costofab Costofab)
        {
            _context.Costofab.Add(Costofab);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (CostofabExists(Costofab.CG_ORDF))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetCostofab", new { id = Costofab.CG_ORDF }, Costofab);
        }

        // DELETE: api/Costofab/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Costofab>> DeleteCostofab(int id)
        {
            var Costofab = await _context.Costofab.FindAsync(id);
            if (Costofab == null)
            {
                return NotFound();
            }

            _context.Costofab.Remove(Costofab);
            await _context.SaveChangesAsync();

            return Costofab;
        }

        private bool CostofabExists(int id)
        {
            return _context.Costofab.Any(e => e.CG_ORDF == id);
        }
    }
}