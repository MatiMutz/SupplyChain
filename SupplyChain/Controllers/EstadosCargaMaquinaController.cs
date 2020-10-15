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
    public class EstadosCargaMaquinaController : ControllerBase
    {
        private readonly AppDbContext _context;

        public EstadosCargaMaquinaController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Areas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EstadosCargaMaquinas>>> GetUnidades()
        {
            return await _context.EstadosCargaMaquinass.ToListAsync();
        }

        // GET: api/Areas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EstadosCargaMaquinas>> GetUnidad(int id)
        {
            var estadocargamaquina = await _context.EstadosCargaMaquinass.FindAsync(id);

            if (estadocargamaquina == null)
            {
                return NotFound();
            }

            return estadocargamaquina;
        }

        // PUT: api/Unidades/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUnidad(int id, EstadosCargaMaquinas estadocargamaquina)
        {
            if (id != estadocargamaquina.CG_ESTADO)
            {
                return BadRequest();
            }

            _context.Entry(estadocargamaquina).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UnidadExists(id))
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

        // POST: api/Unidades
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<EstadosCargaMaquinas>> PostUnidad(EstadosCargaMaquinas estadocargamaquina)
        {
            _context.EstadosCargaMaquinass.Add(estadocargamaquina);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (UnidadExists(estadocargamaquina.CG_ESTADO))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetUnidad", new { id = estadocargamaquina.CG_ESTADO }, estadocargamaquina);
        }

        // DELETE: api/Unidades/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<EstadosCargaMaquinas>> DeleteUnidad(int id)
        {
            var estadocargamaquina = await _context.EstadosCargaMaquinass.FindAsync(id);
            if (estadocargamaquina == null)
            {
                return NotFound();
            }

            _context.EstadosCargaMaquinass.Remove(estadocargamaquina);
            await _context.SaveChangesAsync();

            return estadocargamaquina;
        }

        private bool UnidadExists(int id)
        {
            return _context.EstadosCargaMaquinass.Any(e => e.CG_ESTADO == id);
        }
    }
}
