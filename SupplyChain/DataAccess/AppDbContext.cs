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
        public DbSet<Operario> Operario { get; set; }
        public DbSet<CatOpe> CateOperarios { get; set; }
        public DbSet<User> Usuarios { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Compra> Compras { get; set; }
        public virtual DbSet<Deposito> Depositos { get; set; }
        public virtual DbSet<Stock> Pedidos { get; set; }
        public DbSet<ResumenStock> ResumenStock { get; set; }
        public DbSet<Programa> Programas { get; set; }
        public DbSet<Model> Modelo { get; set; }
        public DbSet<Medid> Medida { get; set; }
        public DbSet<Serie> Serie { get; set; }
        public DbSet<Orific> Orificio { get; set; }
        public DbSet<Marc> Marca { get; set; }
        public DbSet<Servicios> Servicios { get; set; }
        public DbSet<Prodd> Prod { get; set; }
        public DbSet<Sobrepres> Sobrepresion { get; set; }
        public DbSet<Tip> Tipo { get; set; }
        public DbSet<Estad> Estado { get; set; }
        public DbSet<TipArea> Tiarea { get; set; }
        public DbSet<TipCelda> Ticelda { get; set; }
        public DbSet<TipMat> Timat { get; set; }
        public DbSet<TipNoConf> Tinconf { get; set; }
        public DbSet<TrabajosEfec> TrabajosEfec { get; set; }
        public DbSet<Pedcli> Pedcli { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { }

    }
}
