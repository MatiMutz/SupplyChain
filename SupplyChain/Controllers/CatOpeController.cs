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
    public class CatOpeController : ControllerBase
    {
        private readonly AppDbContext _context;

        public CatOpeController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/CatOpe
        [HttpGet]
        public IEnumerable<CatOpeEntity> Get()
        {
            var xitem = _context.CateOperarios.ToList();
            return xitem;
        }
    }
}