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
    public class TipoMatController : ControllerBase
    {
        private readonly AppDbContext _context;

        public TipoMatController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/TipoMat
        [HttpGet]
        public IEnumerable<TipMat> Get()
        {
            var xitem = _context.Timat.ToList();
            return xitem;
        }

        // PUT: api/TipoMat/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(string id, TipMat xitem)
        {
            if (id != xitem.Tipo)
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
        public async Task<ActionResult<TipMat>> Post(TipMat xitem)
        {
            try
            {
                xitem.Tipo = "0";
                _context.Timat.Add(xitem);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
            }
            return CreatedAtAction("Get", new { id = xitem.Tipo }, xitem);
        }

        // DELETE: api/TipoArea/{id}
        [HttpDelete("{id}")]
        public async Task<ActionResult<TipMat>> Delete(int id)
        {
            var xitem = await _context.Timat.FindAsync(id);
            if (xitem == null)
            {
                return NotFound();
            }

            _context.Timat.Remove(xitem);
            await _context.SaveChangesAsync();

            return xitem;
        }

        private bool Existe(string id)
        {
            return _context.Timat.Any(e => e.Tipo == id);
        }
    }
}