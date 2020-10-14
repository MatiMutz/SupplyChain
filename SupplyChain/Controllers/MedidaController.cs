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
    public class MedidaController : ControllerBase
    {
        private readonly AppDbContext _context;

        public MedidaController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Medida
        [HttpGet]
        public IEnumerable<Medid> Get()
        {
            var xitem = _context.Medida.ToList();
            return (IEnumerable<Medid>)xitem;
        }

        // PUT: api/Medida/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, Medid xitem)
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

        // POST: api/Medida
        [HttpPost]
        public async Task<ActionResult<Medid>> Post(Medid xitem)
        {
            try
            {
                xitem.Id = 0;
                _context.Medida.Add(xitem);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
            }
            return CreatedAtAction("Get", new { id = xitem.Id }, xitem);
        }

        // DELETE: api/Medida/{id}
        [HttpDelete("{id}")]
        public async Task<ActionResult<Medid>> Delete(int id)
        {
            var xitem = await _context.Medida.FindAsync(id);
            if (xitem == null)
            {
                return NotFound();
            }

            _context.Medida.Remove(xitem);
            await _context.SaveChangesAsync();

            return xitem;
        }

        private bool Existe(int id)
        {
            return _context.Medida.Any(e => e.Id == id);
        }
    }
}