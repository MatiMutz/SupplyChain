using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SupplyChain.Server.DataAccess;

namespace SupplyChain
{
    [Route("api/[controller]")]
    [ApiController]
    public class TurnosController : ControllerBase
    {
        private readonly AppDbContext _context;

        public TurnosController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Turnos
        [HttpGet]
        public IEnumerable<TurnosEntity> Get()
        {
            var xitem = _context.Turnos.ToList();
            return xitem;
        }
    }
}