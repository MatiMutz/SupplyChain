﻿using SupplyChain;
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
        public DbSet<Monedas> Monedas { get; set; }
        public DbSet<Turnos> Turnos { get; set; }
        public DbSet<Operario> Operario { get; set; }
        public DbSet<CatOpe> CateOperarios { get; set; }
        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Compra> Compras { get; set; }
        public virtual DbSet<Deposito> Depositos { get; set; }
        public virtual DbSet<Stock> Pedidos { get; set; }
        public DbSet<ResumenStock> ResumenStock { get; set; }
        public DbSet<Programa> Programas { get; set; }
        public DbSet<Modelo> Modelo { get; set; }
        public DbSet<Medida> Medida { get; set; }
        public DbSet<Serie> Serie { get; set; }
        public DbSet<Orificio> Orificio { get; set; }
        public DbSet<Marca> Marca { get; set; }
        public DbSet<Servicios> Servicios { get; set; }
        public DbSet<Prod> Prod { get; set; }
        public DbSet<Sobrepresion> Sobrepresion { get; set; }
        public DbSet<Tipo> Tipo { get; set; }
        public DbSet<Estado> Estado { get; set; }
        public DbSet<TipoArea> TipoArea { get; set; }
        public DbSet<TipoCelda> TipoCelda { get; set; }
        public DbSet<TipoMat> TipoMat { get; set; }
        public DbSet<TiposNoConf> TiposNoConf { get; set; }
        public DbSet<Trabajosefec> Trabajosefec { get; set; }
        public DbSet<Pedcli> Pedcli { get; set; }
        public DbSet<EstadosCargaMaquinas> EstadosCargaMaquinass { get; set; }
        public DbSet<Unidad> Unidades { get; set; }
<<<<<<< HEAD
        public DbSet<Area> Areas { get; set; }
        public DbSet<Cia> Cias { get; set; }
        public DbSet<Vende> Vendes { get; set; }
        public DbSet<Pais> Paises { get; set; }
        public DbSet<Iva> Ivas { get; set; }
        public DbSet<Indic> Indics { get; set; }
        public DbSet<ItemsAbastecimiento> ItemsAbastecimientos { get; set; }
        public DbSet<Celda> Celdas { get; set; }
=======
        public DbSet<Scrap> Scrap { get; set; }
        public DbSet<Paradas> Paradas { get; set; }
        public DbSet<Lineas> Lineas { get; set; }
        public DbSet<Clases> Clases { get; set; }
        public DbSet<CalendarioFestivos> CalendarioFestivos { get; set; }
        public DbSet<Costofab> Costofab { get; set; }
>>>>>>> 48529239c8b28f6c7d988b4387ec283da422d4a9
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { }

    }
}
