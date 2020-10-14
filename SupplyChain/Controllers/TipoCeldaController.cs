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
    public class TipoCeldaController : ControllerBase
    {
        private readonly AppDbContext _context;

        public TipoCeldaController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Tipo
        [HttpGet]
        public IEnumerable<TipCelda> Get()
        {
            var xitem = _context.Ticelda.ToList();
            return xitem;
        }

        // PUT: api/TipoCelda/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, TipCelda xitem)
        {
            if (id != xitem.Cg_tipocelda)
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

        // POST: api/TipoArea
        [HttpPost]
        public async Task<ActionResult<TipCelda>> Post(TipCelda xitem)
        {
            try
            {
                xitem.Cg_tipocelda = 0;
                _context.Ticelda.Add(xitem);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
            }
            return CreatedAtAction("Get", new { id = xitem.Cg_tipocelda }, xitem);
        }

        // DELETE: api/TipoArea/{id}
        [HttpDelete("{id}")]
        public async Task<ActionResult<TipCelda>> Delete(int id)
        {
            var xitem = await _context.Ticelda.FindAsync(id);
            if (xitem == null)
            {
                return NotFound();
            }

            _context.Ticelda.Remove(xitem);
            await _context.SaveChangesAsync();

            return xitem;
        }

        private bool Existe(int id)
        {
            return _context.Ticelda.Any(e => e.Cg_tipocelda == id);
        }
    }
}