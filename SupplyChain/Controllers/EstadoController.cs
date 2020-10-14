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
    public class EstadoController : ControllerBase
    {
        private readonly AppDbContext _context;

        public EstadoController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Estado
        [HttpGet]
        public IEnumerable<Estad> Get()
        {
            var xitem = _context.Estado.ToList();
            return xitem;
        }

        // PUT: api/Estado/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, Estad xitem)
        {
            if (id != xitem.Id)
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

        // POST: api/Estado
        [HttpPost]
        public async Task<ActionResult<Estad>> Post(Estad xitem)
        {
            try
            {
                xitem.Id = 0;
                _context.Estado.Add(xitem);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
            }
            return CreatedAtAction("Get", new { id = xitem.Id }, xitem);
        }

        // DELETE: api/Estado/{id}
        [HttpDelete("{id}")]
        public async Task<ActionResult<Estad>> Delete(int id)
        {
            var xitem = await _context.Estado.FindAsync(id);
            if (xitem == null)
            {
                return NotFound();
            }

            _context.Estado.Remove(xitem);
            await _context.SaveChangesAsync();

            return xitem;
        }

        private bool Existe(int id)
        {
            return _context.Estado.Any(e => e.Id == id);
        }
    }
}