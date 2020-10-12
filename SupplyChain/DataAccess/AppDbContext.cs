using SupplyChain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SupplyChain.Shared.Models;

namespace SupplyChain.Server.DataAccess
{
    public class AppDbContext : DbContext
    {
        public DbSet<MonedasEntity> Monedas { get; set; }
        public DbSet<TurnosEntity> Turnos { get; set; }
        public DbSet<OperarioEntity> Operario { get; set; }
        public DbSet<CatOpeEntity> CateOperarios { get; set; }
        public DbSet<UsuarioEntity> Usuarios { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Compra> Compras { get; set; }
        public virtual DbSet<Deposito> Depositos { get; set; }
        public virtual DbSet<Stock> Pedidos { get; set; }
        public DbSet<ResumenStock> ResumenStock { get; set; }
        public DbSet<Programa> Programas { get; set; }

        //

        public DbSet<Modelo> Modelo { get; set; }
        public DbSet<Medida> Medida { get; set; }
        public DbSet<Serie> Serie { get; set; }
        public DbSet<Orificio> Orificio { get; set; }
        public DbSet<Marca> Marca { get; set; }

        //

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { }

    }
}
