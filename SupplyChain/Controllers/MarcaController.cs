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
    public class MarcaController : ControllerBase
    {
        private readonly AppDbContext _context;

        public MarcaController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Marca
        [HttpGet]
        public IEnumerable<Marc> Get()
        {
            var xitem = _context.Marca.ToList();
            return (IEnumerable<Marc>)xitem;
        }

        // PUT: api/Marca/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, Marc xitem)
        {
            if (id != xitem.Id)
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

        // POST: api/Marca
        [HttpPost]
        public async Task<ActionResult<Marc>> Post(Marc xitem)
        {
            try
            {
                xitem.Id = 0;
                _context.Marca.Add(xitem);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
            }
            return CreatedAtAction("Get", new { id = xitem.Id }, xitem);
        }

        // DELETE: api/Marca/{id}
        [HttpDelete("{id}")]
        public async Task<ActionResult<Marc>> Delete(int id)
        {
            var xitem = await _context.Marca.FindAsync(id);
            if (xitem == null)
            {
                return NotFound();
            }

            _context.Marca.Remove(xitem);
            await _context.SaveChangesAsync();

            return xitem;
        }

        private bool Existe(int id)
        {
            return _context.Marca.Any(e => e.Id == id);
        }
    }
}