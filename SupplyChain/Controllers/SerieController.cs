﻿using System;
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
    public class SerieController : ControllerBase
    {
        private readonly AppDbContext _context;

        public SerieController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Serie
        [HttpGet]
        public IEnumerable<Serie> Get()
        {
            var xitem = _context.Serie.ToList();
            return (IEnumerable<Serie>)xitem;
        }

        // PUT: api/Serie/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, Serie xitem)
        {
            if (id != xitem.ID)
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

        // POST: api/Serie
        [HttpPost]
        public async Task<ActionResult<Serie>> Post(Serie xitem)
        {
            try
            {
                xitem.ID = 0;
                _context.Serie.Add(xitem);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
            }
            return CreatedAtAction("Get", new { id = xitem.ID }, xitem);
        }

        // DELETE: api/Serie/{id}
        [HttpDelete("{id}")]
        public async Task<ActionResult<Serie>> Delete(int id)
        {
            var xitem = await _context.Serie.FindAsync(id);
            if (xitem == null)
            {
                return NotFound();
            }

            _context.Serie.Remove(xitem);
            await _context.SaveChangesAsync();

            return xitem;
        }

        private bool Existe(int id)
        {
            return _context.Serie.Any(e => e.ID == id);
        }
    }
}