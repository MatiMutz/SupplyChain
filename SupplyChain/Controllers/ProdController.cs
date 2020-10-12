using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SupplyChain.Server.DataAccess;

namespace SupplyChain
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ProdController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Prod
        [HttpGet]
        public IEnumerable<ProdPage> Get()
        {
            var xitem = _context.ProdPage.ToList();
            return xitem;
        }

        // PUT: api/Prod/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, ProdPage xitem)
        {
            if (id != xitem.CG_PROD)
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

        // POST: api/Prod                                                                                                                                                                   
        [HttpPost]
        public async Task<ActionResult<ProdPage>> Post(ProdPage xitem)
        {
            try
            {
                xitem.CG_PROD = 0;
                _context.ProdPage.Add(xitem);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
            }
            return CreatedAtAction("Get", new { id = xitem.CG_PROD }, xitem);
        }

        // DELETE: api/Prod/{id}
        [HttpDelete("{id}")]
        public async Task<ActionResult<ProdPage>> Delete(int id)
        {
            var xitem = await _context.ProdPage.FindAsync(id);
            if (xitem == null)
            {
                return NotFound();
            }

            _context.ProdPage.Remove(xitem);
            await _context.SaveChangesAsync();

            return xitem;
        }

        private bool Existe(int id)
        {
            return _context.ProdPage.Any(e => e.CG_PROD == id);
        }
    }
}