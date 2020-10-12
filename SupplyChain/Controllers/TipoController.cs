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
    public class TipoController : ControllerBase
    {
        private readonly AppDbContext _context;

        public TipoController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Tipo
        [HttpGet]
        public IEnumerable<Tip> Get()
        {
            var xitem = _context.Tipo.ToList();
            return xitem;
        }

        // PUT: api/Tipo/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, Tip xitem)
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

        // POST: api/Tipo
        [HttpPost]
        public async Task<ActionResult<Tip>> Post(Tip xitem)
        {
            try
            {
                xitem.Id = 0;
                _context.Tipo.Add(xitem);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
            }
            return CreatedAtAction("Get", new { id = xitem.Id }, xitem);
        }

        // DELETE: api/Tipo/{id}
        [HttpDelete("{id}")]
        public async Task<ActionResult<Tip>> Delete(int id)
        {
            var xitem = await _context.Tipo.FindAsync(id);
            if (xitem == null)
            {
                return NotFound();
            }

            _context.Tipo.Remove(xitem);
            await _context.SaveChangesAsync();

            return xitem;
        }

        private bool Existe(int id)
        {
            return _context.Tipo.Any(e => e.Id == id);
        }
    }
}