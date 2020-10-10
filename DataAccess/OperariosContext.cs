using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public class OperariosContext : DbContext
    {
        public DbSet<OperarioEntity> Operario { get; set; }
        public DbSet<CatOpeEntity> CateOperarios { get; set; }
        public DbSet<UsuarioEntity> Usuarios { get; set; }
        public DbSet<ClienteEntity> Cliente { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                options.UseSqlServer("Server=localhost\\SQLEXPRESS; Database=WEBSOLUTIION;Trusted_Connection=true;MultipleActiveResultSets=true");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UsuarioEntity>().HasNoKey();
        }
    }
}
