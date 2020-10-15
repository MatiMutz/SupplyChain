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
    public class CalendarioFestivosController : ControllerBase
    {
        private readonly AppDbContext _context;

        public CalendarioFestivosController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/CalendarioFestivos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CalendarioFestivos>>> GetCalendarioFestivos()
        {
            return await _context.CalendarioFestivos.ToListAsync();
        }

        // GET: api/CalendarioFestivos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CalendarioFestivos>> GetCalendarioFestivos(int id)
        {
            var CalendarioFestivos = await _context.CalendarioFestivos.FindAsync(id);

            if (CalendarioFestivos == null)
            {
                return NotFound();
            }

            return CalendarioFestivos;
        }

        // PUT: api/CalendarioFestivos/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCalendarioFestivos(int id, CalendarioFestivos CalendarioFestivos)
        {
            if (id != CalendarioFestivos.Registro)
            {
                return BadRequest();
            }

            _context.Entry(CalendarioFestivos).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CalendarioFestivosExists(id))
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

        // POST: api/CalendarioFestivos
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<CalendarioFestivos>> PostCalendarioFestivos(CalendarioFestivos CalendarioFestivos)
        {
            _context.CalendarioFestivos.Add(CalendarioFestivos);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (CalendarioFestivosExists(CalendarioFestivos.Registro))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetCalendarioFestivos", new { id = CalendarioFestivos.Registro }, CalendarioFestivos);
        }

        // DELETE: api/CalendarioFestivos/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<CalendarioFestivos>> DeleteCalendarioFestivos(int id)
        {
            var CalendarioFestivos = await _context.CalendarioFestivos.FindAsync(id);
            if (CalendarioFestivos == null)
            {
                return NotFound();
            }

            _context.CalendarioFestivos.Remove(CalendarioFestivos);
            await _context.SaveChangesAsync();

            return CalendarioFestivos;
        }

        private bool CalendarioFestivosExists(int id)
        {
            return _context.CalendarioFestivos.Any(e => e.Registro == id);
        }
    }
}