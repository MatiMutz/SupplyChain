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
    public class SobrepresionController : ControllerBase
    {
        private readonly AppDbContext _context;

        public SobrepresionController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Sobrepresion
        [HttpGet]
        public IEnumerable<Sobrepres> Get()
        {
            var xitem = _context.Sobrepresion.ToList();
            return xitem;
        }

        // PUT: api/Sobrepresion/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, Sobrepres xitem)
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

        // POST: api/Sobrepresion
        [HttpPost]
        public async Task<ActionResult<Sobrepres>> Post(Sobrepres xitem)
        {
            try
            {
                xitem.Id = 0;
                _context.Sobrepresion.Add(xitem);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
            }
            return CreatedAtAction("Get", new { id = xitem.Id }, xitem);
        }

        // DELETE: api/Sobrepresion/{id}
        [HttpDelete("{id}")]
        public async Task<ActionResult<Sobrepres>> Delete(int id)
        {
            var xitem = await _context.Sobrepresion.FindAsync(id);
            if (xitem == null)
            {
                return NotFound();
            }

            _context.Sobrepresion.Remove(xitem);
            await _context.SaveChangesAsync();

            return xitem;
        }

        private bool Existe(int id)
        {
            return _context.Sobrepresion.Any(e => e.Id == id);
        }
    }
}