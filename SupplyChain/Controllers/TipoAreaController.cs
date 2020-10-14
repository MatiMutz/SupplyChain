using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SupplyChain.Server.DataAccess;
using SupplyChain.Shared.Models;

namespace SupplyChain
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipoAreaController : ControllerBase
    {
        private readonly AppDbContext _context;

        public TipoAreaController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Tipo
        [HttpGet]
        public IEnumerable<TipArea> Get()
        {
            var xitem = _context.Tiarea.ToList();
            return xitem;
        }

        // PUT: api/TipoArea/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, TipArea xitem)
        {
            if (id != xitem.Cg_tipoarea)
            {
                return BadRequest();
            }

            _context.Entry(xitem).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Existe(id))
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

        // POST: api/TipoArea
        [HttpPost]
        public async Task<ActionResult<TipArea>> Post(TipArea xitem)
        {
            try
            {
                xitem.Cg_tipoarea = 0;
                _context.Tiarea.Add(xitem);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
            }
            return CreatedAtAction("Get", new { id = xitem.Cg_tipoarea }, xitem);
        }

        // DELETE: api/TipoArea/{id}
        [HttpDelete("{id}")]
        public async Task<ActionResult<TipArea>> Delete(int id)
        {
            var xitem = await _context.Tiarea.FindAsync(id);
            if (xitem == null)
            {
                return NotFound();
            }

            _context.Tiarea.Remove(xitem);
            await _context.SaveChangesAsync();

            return xitem;
        }

        private bool Existe(int id)
        {
            return _context.Tiarea.Any(e => e.Cg_tipoarea == id);
        }
    }
}