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
    public class PedcliController : ControllerBase
    {
        private readonly AppDbContext _context;

        public PedcliController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Pedcli
        [HttpGet]
        public IEnumerable<Pedcli> Get()
        {
            var xitem = _context.Pedcli.ToList();
            return xitem;
        }

        // PUT: api/Pedcli/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, Pedcli xitem)
        {
            if (id != xitem.REGISTRO)
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

        // POST: api/Pedcli
        [HttpPost]
        public async Task<ActionResult<Pedcli>> Post(Pedcli xitem)
        {
            try
            {
                xitem.REGISTRO = 0;
                _context.Pedcli.Add(xitem);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
            }
            return CreatedAtAction("Get", new { id = xitem.REGISTRO }, xitem);
        }

        // DELETE: api/Pedcli/{id}
        [HttpDelete("{id}")]
        public async Task<ActionResult<Pedcli>> Delete(int id)
        {
            var xitem = await _context.Pedcli.FindAsync(id);
            if (xitem == null)
            {
                return NotFound();
            }

            _context.Pedcli.Remove(xitem);
            await _context.SaveChangesAsync();

            return xitem;
        }

        private bool Existe(int id)
        {
            return _context.Pedcli.Any(e => e.REGISTRO == id);
        }
    }
}