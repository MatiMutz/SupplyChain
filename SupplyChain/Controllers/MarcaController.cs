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
    public class MarcaController : ControllerBase
    {
        private readonly AppDbContext _context;

        public MarcaController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Operario
        [HttpGet]
        public IEnumerable<Marca> Get()
        {
            var xitem = _context.Marca.ToList();
            return (IEnumerable<Marca>)xitem;
        }

        // PUT: api/Operario/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, Marca xitem)
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

        // POST: api/Operario
        [HttpPost]
        public async Task<ActionResult<Marca>> Post(Marca xitem)
        {
            try
            {
                xitem.ID = 0;
                _context.Marca.Add(xitem);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
            }
            return CreatedAtAction("Get", new { id = xitem.ID }, xitem);
        }

        // DELETE: api/Operario/{id}
        [HttpDelete("{id}")]
        public async Task<ActionResult<Marca>> Delete(int id)
        {
            var xitem = await _context.Marca.FindAsync(id);
            if (xitem == null)
            {
                return NotFound();
            }

            _context.Marca.Remove(xitem);
            await _context.SaveChangesAsync();

            return xitem;
        }

        private bool Existe(int id)
        {
            return _context.Marca.Any(e => e.ID == id);
        }
    }
}