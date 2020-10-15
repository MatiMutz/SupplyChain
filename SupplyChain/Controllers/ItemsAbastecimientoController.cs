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
    public class ItemsAbastecimientoController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ItemsAbastecimientoController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Areas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ItemsAbastecimiento>>> GetUnidades()
        {
            return await _context.ItemsAbastecimientos.ToListAsync();
        }

        // GET: api/Areas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ItemsAbastecimiento>> GetUnidad(string id)
        {
            var itemabastecimiento = await _context.ItemsAbastecimientos.FindAsync(id);

            if (itemabastecimiento == null)
            {
                return NotFound();
            }

            return itemabastecimiento;
        }

        // PUT: api/Unidades/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUnidad(string id, ItemsAbastecimiento itemabastecimiento)
        {
            if (id != itemabastecimiento.CG_ART)
            {
                return BadRequest();
            }

            _context.Entry(itemabastecimiento).State = EntityState.Modified;

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
        public async Task<ActionResult<ItemsAbastecimiento>> PostUnidad(ItemsAbastecimiento itemabastecimiento)
        {
            _context.ItemsAbastecimientos.Add(itemabastecimiento);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (UnidadExists(itemabastecimiento.CG_ART))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetUnidad", new { id = itemabastecimiento.CG_ART }, itemabastecimiento);
        }

        // DELETE: api/Unidades/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ItemsAbastecimiento>> DeleteUnidad(string id)
        {
            var itemabastecimiento = await _context.ItemsAbastecimientos.FindAsync(id);
            if (itemabastecimiento == null)
            {
                return NotFound();
            }

            _context.ItemsAbastecimientos.Remove(itemabastecimiento);
            await _context.SaveChangesAsync();

            return itemabastecimiento;
        }

        private bool UnidadExists(string id)
        {
            return _context.ItemsAbastecimientos.Any(e => e.CG_ART == id);
        }
    }
}
