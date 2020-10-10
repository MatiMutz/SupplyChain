﻿using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SupplyChain.Shared.Models;
using SupplyChain.Shared;
using SupplyChain.Server.DataAccess;

namespace PCP.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProgramasController : ControllerBase
    {
        private readonly AppDbContext _context;
        private int cg_cia_usuario = 1; /*CAMBIAR POR LA DEL USUARIO*/

        public ProgramasController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Programas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Programa>>> GetProgramas()
        {
            return await _context.Programas.Where(p => p.Cg_Cia == cg_cia_usuario)
                .Take(20).ToListAsync();
 
        }

        // GET: api/Programas/GetAbastecimientoByOF/73411
        [HttpGet("GetAbastecimientoByOF/{cg_ordf:int}")]
        public async Task<ActionResult<IEnumerable<ItemAbastecimiento>>> GetAbastecimientoByOF(int cg_ordf)
        {
            var dt = new DataTable();
            List<ItemAbastecimiento> itemAbastecimiento;
            var usuario = "user";

            
            //using (var command = _context.Database.GetDbConnection().CreateCommand())
            //{
            //    var sp = $"Execute NET_PCP_TraerAbast {cg_ordf}, '{usuario}'";
            //    command.CommandText = sp; //$"Execute NET_PCP_TraerAbast";
            //    //command.CommandType = CommandType.StoredProcedure;
            //    //command.Parameters.Add(new SqlParameter("@Cg_Ordf", cg_ordf));
            //    //command.Parameters.Add(new SqlParameter("@Usuario", usuario));
            //    var conn = command.Connection;
                
            //    if (conn.State != ConnectionState.Open) conn.Open();

            //    using (var result = await command.ExecuteReaderAsync())
            //    {
            //        //dt.Load(result);

            //        //var eee = await Helpers.ConvertDataTable<ItemAbastecimiento>(dt);
                    
                    
            //    }
            //}

            //El modelo esta seteado en context
            var of = new SqlParameter("of", cg_ordf);
            itemAbastecimiento = await _context.Set<ItemAbastecimiento>()
                .FromSqlRaw("Exec dbo.NET_PCP_TraerAbast  @Cg_Ordf=@of", of)
                .ToListAsync();

            return itemAbastecimiento;

        }

        // GET: api/Programas/GetProgramaByOF/cg_ordf
        [HttpGet("GetProgramaByOF/{cg_ordf}")]
        public async Task<ActionResult<IEnumerable<Programa>>> GetCompraByOF(decimal cg_ordf)
        {
            return await _context.Programas.Where(p => p.Cg_Cia == cg_cia_usuario 
                    && p.CG_ORDF == cg_ordf).ToListAsync();

        }

        // GET: api/Programas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Programa>> GetPrograma(decimal id)
        {
            var programa = await _context.Programas.FindAsync(id);

            if (programa == null)
            {
                return NotFound();
            }

            return programa;
        }

        // PUT: api/Programas/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPrograma(decimal id, Programa programa)
        {
            if (id != programa.REGISTRO)
            {
                return BadRequest();
            }

            _context.Entry(programa).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProgramaExists(id))
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

        // POST: api/Programas
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Programa>> PostPrograma(Programa programa)
        {
            _context.Programas.Add(programa);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPrograma", new { id = programa.REGISTRO }, programa);
        }

        // DELETE: api/Programas/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Programa>> DeletePrograma(decimal id)
        {
            var programa = await _context.Programas.FindAsync(id);
            if (programa == null)
            {
                return NotFound();
            }

            _context.Programas.Remove(programa);
            await _context.SaveChangesAsync();

            return programa;
        }

        private bool ProgramaExists(decimal id)
        {
            return _context.Programas.Any(e => e.REGISTRO == id);
        }
    }
}
