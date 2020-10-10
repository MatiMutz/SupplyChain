﻿// <auto-generated />
using System;
using DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataAccess.Migrations
{
    [DbContext(typeof(OperariosContext))]
    partial class OperariosContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Entities.CatOpeEntity", b =>
                {
                    b.Property<string>("CG_CATEOP")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("DES_CATEOP")
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.HasKey("CG_CATEOP");

                    b.ToTable("CateOperarios");
                });

            modelBuilder.Entity("Entities.ClienteEntity", b =>
                {
                    b.Property<int>("CG_CLI")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DES_CLI")
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.HasKey("CG_CLI");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("Entities.OperarioEntity", b =>
                {
                    b.Property<int>("CG_OPER")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("ACTIVO")
                        .HasColumnType("bit");

                    b.Property<string>("CG_CATEOP")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<int>("CG_CIA")
                        .HasColumnType("int");

                    b.Property<int>("CG_TURNO")
                        .HasColumnType("int");

                    b.Property<string>("DES_OPER")
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.Property<DateTime?>("FE_FINAL")
                        .HasColumnType("datetime2");

                    b.Property<int>("HS_FINAL")
                        .HasColumnType("int");

                    b.Property<string>("MONEDA")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<decimal>("RENDIM")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("USUARIO")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<decimal>("VALOR_HORA")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("CG_OPER");

                    b.ToTable("Operario");
                });

            modelBuilder.Entity("Entities.UsuarioEntity", b =>
                {
                    b.Property<string>("Usuario")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.ToTable("Usuarios");
                });
#pragma warning restore 612, 618
        }
    }
}
