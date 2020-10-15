using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SupplyChain.Server.DataAccess;
using SupplyChain.Shared.Models;

namespace SupplyChain.Server.Controllers
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

        // GET: api/Servicios
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Servicios>>> GetServicios()
        {
            return await _context.Servicios.ToListAsync();
        }

        // GET: api/Servicios/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Servicios>> GetServicios(string id)
        {
            var Servicios = await _context.Servicios.FindAsync(id);

            if (Servicios == null)
            {
                return NotFound();
            }

            return Servicios;
        }

        // PUT: api/Servicios/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutServicios(string id, Servicios Servicios)
        {
            if (id != Servicios.PEDIDO)
            {
                return BadRequest();
            }

            _context.Entry(Servicios).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ServiciosExists(id))
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

        // POST: api/Servicios
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Servicios>> PostServicios(Servicios Servicios)
        {
            _context.Servicios.Add(Servicios);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ServiciosExists(Servicios.PEDIDO))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetServicios", new { id = Servicios.PEDIDO }, Servicios);
        }

        // DELETE: api/Servicios/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Servicios>> DeleteServicios(int id)
        {
            var Servicios = await _context.Servicios.FindAsync(id);
            if (Servicios == null)
            {
                return NotFound();
            }

            _context.Servicios.Remove(Servicios);
            await _context.SaveChangesAsync();

            return Servicios;
        }

        private bool ServiciosExists(string id)
        {
            return _context.Servicios.Any(e => e.PEDIDO == id);
        }
    }
}