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
    public class ServiciosController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ServiciosController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Servicio
        [HttpGet]
        public IEnumerable<Servicio> Get()
        {
            var xitem = _context.Servicios.ToList();
            return xitem;
        }

        // PUT: api/Servicio/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(string id, Servicio xitem)
        {
            if (id != xitem.PEDIDO)
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

        // POST: api/Servicio
        [HttpPost]
        public async Task<ActionResult<Servicio>> Post(Servicio xitem)
        {
            try
            {
                xitem.PEDIDO = "0";
                _context.Servicios.Add(xitem);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
            }
            return CreatedAtAction("Get", new { id = xitem.PEDIDO }, xitem);
        }

        // DELETE: api/Servicio/{id}
        [HttpDelete("{id}")]
        public async Task<ActionResult<Servicio>> Delete(int id)
        {
            var xitem = await _context.Servicios.FindAsync(id);
            if (xitem == null)
            {
                return NotFound();
            }

            _context.Servicios.Remove(xitem);
            await _context.SaveChangesAsync();

            return xitem;
        }

        private bool Existe(string id)
        {
            return _context.Servicios.Any(e => e.PEDIDO == id);
        }
    }
}