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
    public class ServiciosController : Controller
    {
        private readonly AppDbContext _context;

        public ServiciosController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Servicio
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Servicios>>> GetServicios()
        {
            try
            {
                return await _context.Servicios.ToListAsync();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        // GET: api/Servicio/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<Servicios>> GetServicios(decimal id)
        {
            var serv = await _context.Servicios.FindAsync(id);

            if (serv == null)
            {
                return NotFound();
            }

            return serv;
        }

        // PUT: api/Servicio/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> PutServicio(string id, Servicios Serv)
        {
            if (id != Serv.PEDIDO)
            {
                return BadRequest();
            }

            _context.Entry(Serv).State = EntityState.Modified;

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
        public async Task<ActionResult<Servicios>> Post(Servicios xitem)
        {
            _context.Servicios.Add(xitem);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetServicios", new { id = xitem.PEDIDO }, xitem);
        }

        // DELETE: api/Servicio/{id}
        [HttpDelete("{id}")]
        public async Task<ActionResult<Servicios>> Delete(int id)
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