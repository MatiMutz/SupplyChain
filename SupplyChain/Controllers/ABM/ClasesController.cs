﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SupplyChain;

namespace SupplyChain
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClaseController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ClaseController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Clase
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Clase>>> GetClase()
        {
            return await _context.Clase.ToListAsync();
        }

        // GET: api/Clase/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Clase>> GetClase(int id)
        {
            var Clase = await _context.Clase.FindAsync(id);

            if (Clase == null)
            {
                return NotFound();
            }

            return Clase;
        }

        // PUT: api/Clase/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutClase(int id, Clase Clase)
        {
            if (id != Clase.CG_CLASE)
            {
                return BadRequest();
            }

            _context.Entry(Clase).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ClaseExists(id))
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

        // POST: api/Clase
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Clase>> PostClase(Clase Clase)
        {
            _context.Clase.Add(Clase);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ClaseExists(Clase.CG_CLASE))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetClase", new { id = Clase.CG_CLASE }, Clase);
        }

        // DELETE: api/Clase/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Clase>> DeleteClase(int id)
        {
            var Clase = await _context.Clase.FindAsync(id);
            if (Clase == null)
            {
                return NotFound();
            }

            _context.Clase.Remove(Clase);
            await _context.SaveChangesAsync();

            return Clase;
        }

        private bool ClaseExists(int id)
        {
            return _context.Clase.Any(e => e.CG_CLASE == id);
        }
    }
}