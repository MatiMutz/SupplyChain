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
    public class MonedasController : ControllerBase
    {
        private readonly AppDbContext _context;

        public MonedasController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Monedas
        [HttpGet]
        public IEnumerable<MonedasEntity> Get()
        {
            var xitem = _context.Monedas.ToList();
            return xitem;
        }
    }
}