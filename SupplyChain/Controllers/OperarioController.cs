using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace SupplyChain
{
    [Route("api/[controller]")]
    [ApiController]
    public class OperarioController : ControllerBase
    {
        private readonly AppDbContext _context;

        public OperarioController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Operario
        [HttpGet]
        public IEnumerable<OperarioEntity> Get()
        {
            var xitem = _context.Operario.ToList();
            return xitem;
        }

        // PUT: api/Operario/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, OperarioEntity xitem)
        {
            if (id != xitem.CG_OPER)
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

        // POST: api/Operario
        [HttpPost]
        public async Task<ActionResult<OperarioEntity>> Post(OperarioEntity xitem)
        {
            try
            {
                _context.Operario.Add(xitem);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
            }
            return CreatedAtAction("Get", new { id = xitem.CG_OPER }, xitem);
        }

        // DELETE: api/Operario/{id}
        [HttpDelete("{id}")]
        public async Task<ActionResult<OperarioEntity>> Delete(int id)
        {
            var xitem = await _context.Operario.FindAsync(id);
            if (xitem == null)
            {
                return NotFound();
            }

            _context.Operario.Remove(xitem);
            await _context.SaveChangesAsync();

            return xitem;
        }

        private bool Existe(int id)
        {
            return _context.Operario.Any(e => e.CG_OPER == id);
        }
    }
}