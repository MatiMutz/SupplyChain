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
        public DbSet<Area> Area { get; set; }
        public DbSet<CatOpe> CatOpe { get; set; }
        public DbSet<Celdas> Celda { get; set; }
        public DbSet<Clase> Clase { get; set; }
        public DbSet<Deposito> Deposito { get; set; }
        public DbSet<Indic> Indic { get; set; }
        public DbSet<Lineas> Lineas { get; set; }
        public DbSet<Monedas> Monedas { get; set; }
        public DbSet<Operario> Operario { get; set; }
        public DbSet<Pais> Pais { get; set; }
        public DbSet<Paradas> Paradas { get; set; }
        public DbSet<Prod> Prod { get; set; }
        public DbSet<Scrap> Scrap { get; set; }
        public DbSet<TipoArea> TipoArea { get; set; }
        public DbSet<TipoCelda> TipoCelda { get; set; }
        public DbSet<TipoMat> TipoMat { get; set; }
        public DbSet<TiposNoConf> TiposNoConf { get; set; }
        public DbSet<Protab> Protab { get; set; }
        public DbSet<Protarea> Protarea { get; set; }

        
        public DbSet<Turnos> Turnos { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { }
    }
}
