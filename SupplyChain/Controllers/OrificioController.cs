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
    public class OrificioController : ControllerBase
    {
        private readonly AppDbContext _context;

        public OrificioController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Orificio
        [HttpGet]
        public IEnumerable<Orificio> Get()
        {
            var xitem = _context.Orificio.ToList();
            return (IEnumerable<Orificio>)xitem;
        }

        // PUT: api/Orificio/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, Orificio xitem)
        {
            if (id != xitem.ID)
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

        // POST: api/Orificio
        [HttpPost]
        public async Task<ActionResult<Orificio>> Post(Orificio xitem)
        {
            try
            {
                xitem.ID = 0;
                _context.Orificio.Add(xitem);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
            }
            return CreatedAtAction("Get", new { id = xitem.ID }, xitem);
        }

        // DELETE: api/Orificio/{id}
        [HttpDelete("{id}")]
        public async Task<ActionResult<Orificio>> Delete(int id)
        {
            var xitem = await _context.Orificio.FindAsync(id);
            if (xitem == null)
            {
                return NotFound();
            }

            _context.Orificio.Remove(xitem);
            await _context.SaveChangesAsync();

            return xitem;
        }

        private bool Existe(int id)
        {
            return _context.Orificio.Any(e => e.ID == id);
        }
    }
}