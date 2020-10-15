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
    public class PedcliController : ControllerBase
    {
        private readonly AppDbContext _context;

        public PedcliController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Pedcli
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Pedcli>>> GetPedcli()
        {
            return await _context.Pedcli.ToListAsync();
        }

        // GET: api/Pedcli/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Pedcli>> GetPedcli(int id)
        {
            var Pedcli = await _context.Pedcli.FindAsync(id);

            if (Pedcli == null)
            {
                return NotFound();
            }

            return Pedcli;
        }

        // PUT: api/Pedcli/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPedcli(int id, Pedcli Pedcli)
        {
            if (id != Pedcli.REGISTRO)
            {
                return BadRequest();
            }

            _context.Entry(Pedcli).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PedcliExists(id))
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

        // POST: api/Pedcli
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Pedcli>> PostPedcli(Pedcli Pedcli)
        {
            _context.Pedcli.Add(Pedcli);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (PedcliExists(Pedcli.REGISTRO))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetPedcli", new { id = Pedcli.REGISTRO }, Pedcli);
        }

        // DELETE: api/Pedcli/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Pedcli>> DeletePedcli(int id)
        {
            var Pedcli = await _context.Pedcli.FindAsync(id);
            if (Pedcli == null)
            {
                return NotFound();
            }

            _context.Pedcli.Remove(Pedcli);
            await _context.SaveChangesAsync();

            return Pedcli;
        }

        private bool PedcliExists(int id)
        {
            return _context.Pedcli.Any(e => e.REGISTRO == id);
        }
    }
}