using SupplyChain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SupplyChain
{
    public class AppDbContext : DbContext
    {
        public DbSet<MonedasEntity> Monedas { get; set; }
        public DbSet<TurnosEntity> Turnos { get; set; }
        public DbSet<OperarioEntity> Operario { get; set; }
        public DbSet<CatOpeEntity> CateOperarios { get; set; }
        public DbSet<UsuarioEntity> Usuarios { get; set; }
        public DbSet<ClienteEntity> Cliente { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { }
    }
}
