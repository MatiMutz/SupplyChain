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
    public class ModeloController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ModeloController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Modelo
        [HttpGet]
        public IEnumerable<Modelo> Get()
        {
            var xitem = _context.Modelo.ToList();
            return (IEnumerable<Modelo>)xitem;
        }

        // PUT: api/Modelo/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, Modelo xitem)
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

        // POST: api/Modelo
        [HttpPost]
        public async Task<ActionResult<Modelo>> Post(Modelo xitem)
        {
            try
            {
                xitem.ID = 0;
                _context.Modelo.Add(xitem);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
            }
            return CreatedAtAction("Get", new { id = xitem.ID }, xitem);
        }

        // DELETE: api/Modelo/{id}
        [HttpDelete("{id}")]
        public async Task<ActionResult<Modelo>> Delete(int id)
        {
            var xitem = await _context.Modelo.FindAsync(id);
            if (xitem == null)
            {
                return NotFound();
            }

            _context.Modelo.Remove(xitem);
            await _context.SaveChangesAsync();

            return xitem;
        }

        private bool Existe(int id)
        {
            return _context.Modelo.Any(e => e.ID == id);
        }
    }
}