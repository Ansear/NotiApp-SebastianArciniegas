﻿// <auto-generated />
using System;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.Data.Migrations
{
    [DbContext(typeof(NotiAppContext))]
    [Migration("20231017001340_SecondMigrations")]
    partial class SecondMigrations
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Core.Entities.Auditoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("DescAccion")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("date");

                    b.Property<DateTime>("FechaModificacion")
                        .HasColumnType("date");

                    b.Property<string>("NombreUsuario")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Auditoria", (string)null);
                });

            modelBuilder.Entity("Core.Entities.Blockchain", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("date");

                    b.Property<DateTime>("FechaModificacion")
                        .HasColumnType("date");

                    b.Property<string>("HasGenerado")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<int>("IdAuditoria")
                        .HasColumnType("int");

                    b.Property<int>("IdHiloRespuesta")
                        .HasColumnType("int");

                    b.Property<int>("IdNotificacion")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdAuditoria");

                    b.HasIndex("IdHiloRespuesta");

                    b.HasIndex("IdNotificacion");

                    b.ToTable("Blockchain", (string)null);
                });

            modelBuilder.Entity("Core.Entities.EstadoNotificacion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("date");

                    b.Property<DateTime>("FechaModificacion")
                        .HasColumnType("date");

                    b.Property<string>("NombreEstado")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("EstadoNotificacion", (string)null);
                });

            modelBuilder.Entity("Core.Entities.Formatos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("date");

                    b.Property<DateTime>("FechaModificacion")
                        .HasColumnType("date");

                    b.Property<string>("NombreFormato")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Formatos", (string)null);
                });

            modelBuilder.Entity("Core.Entities.GenericosVsSubmodulos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("date");

                    b.Property<DateTime>("FechaModificacion")
                        .HasColumnType("date");

                    b.Property<int>("IdGenericos")
                        .HasColumnType("int");

                    b.Property<int>("IdRol")
                        .HasColumnType("int");

                    b.Property<int>("IdSubModulos")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdGenericos");

                    b.HasIndex("IdRol");

                    b.HasIndex("IdSubModulos");

                    b.ToTable("GenericosVsSubmodulos", (string)null);
                });

            modelBuilder.Entity("Core.Entities.HiloRespuestaNotificacion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("FechaModificacion")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("NombreTipo")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("HiloRespuestaNotificaciones");
                });

            modelBuilder.Entity("Core.Entities.MaestrosVsSubmodulos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("date");

                    b.Property<DateTime>("FechaModificacion")
                        .HasColumnType("date");

                    b.Property<int>("IdMaestro")
                        .HasColumnType("int");

                    b.Property<int>("IdSubModulo")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdMaestro");

                    b.HasIndex("IdSubModulo");

                    b.ToTable("MaestrosVsSubmodulos", (string)null);
                });

            modelBuilder.Entity("Core.Entities.ModuloNotificaciones", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("AsuntoNotificacion")
                        .HasMaxLength(80)
                        .HasColumnType("varchar(80)");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("date");

                    b.Property<DateTime>("FechaModificacion")
                        .HasColumnType("date");

                    b.Property<int>("IdEstadoNotificacion")
                        .HasColumnType("int");

                    b.Property<int>("IdFormato")
                        .HasColumnType("int");

                    b.Property<int>("IdHiloRespuesta")
                        .HasColumnType("int");

                    b.Property<int>("IdRadicado")
                        .HasColumnType("int");

                    b.Property<int>("IdRequereimiento")
                        .HasColumnType("int");

                    b.Property<int>("IdTipoNotificacion")
                        .HasColumnType("int");

                    b.Property<string>("TextoNotificacion")
                        .HasMaxLength(2000)
                        .HasColumnType("varchar(2000)");

                    b.HasKey("Id");

                    b.HasIndex("IdEstadoNotificacion");

                    b.HasIndex("IdFormato");

                    b.HasIndex("IdHiloRespuesta");

                    b.HasIndex("IdRadicado");

                    b.HasIndex("IdRequereimiento");

                    b.HasIndex("IdTipoNotificacion");

                    b.ToTable("ModuloNotificaciones", (string)null);
                });

            modelBuilder.Entity("Core.Entities.ModulosMaestros", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("date");

                    b.Property<DateTime>("FechaModificacion")
                        .HasColumnType("date");

                    b.Property<string>("NombreModulo")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.ToTable("ModulosMaestros", (string)null);
                });

            modelBuilder.Entity("Core.Entities.PermisosGenericos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("date");

                    b.Property<DateTime>("FechaModificacion")
                        .HasColumnType("date");

                    b.Property<string>("NombrePermiso")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("PermisosGenericos", (string)null);
                });

            modelBuilder.Entity("Core.Entities.Radicados", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("date");

                    b.Property<DateTime>("FechaModificacion")
                        .HasColumnType("date");

                    b.HasKey("Id");

                    b.ToTable("Radicados", (string)null);
                });

            modelBuilder.Entity("Core.Entities.Rol", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateOnly>("FechaCreacion")
                        .HasColumnType("date");

                    b.Property<DateOnly>("FechaModificacion")
                        .HasColumnType("date");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Rol", (string)null);
                });

            modelBuilder.Entity("Core.Entities.RolVsMaestro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("date");

                    b.Property<DateTime>("FechaModificacion")
                        .HasColumnType("date");

                    b.Property<int>("IdMaestro")
                        .HasColumnType("int");

                    b.Property<int>("IdRol")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdMaestro");

                    b.HasIndex("IdRol");

                    b.ToTable("RolVsMaestro", (string)null);
                });

            modelBuilder.Entity("Core.Entities.Submodulos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("date");

                    b.Property<DateTime>("FechaModificacion")
                        .HasColumnType("date");

                    b.Property<string>("NombreSubModulo")
                        .HasMaxLength(80)
                        .HasColumnType("varchar(80)");

                    b.HasKey("Id");

                    b.ToTable("SubModulos", (string)null);
                });

            modelBuilder.Entity("Core.Entities.TipoNotificaciones", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("date");

                    b.Property<DateTime>("FechaModificacion")
                        .HasColumnType("date");

                    b.Property<string>("NombreTipo")
                        .HasMaxLength(80)
                        .HasColumnType("varchar(80)");

                    b.HasKey("Id");

                    b.ToTable("TipoNotificaciones", (string)null);
                });

            modelBuilder.Entity("Core.Entities.TipoRequerimiento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("date");

                    b.Property<DateTime>("FechaModificacion")
                        .HasColumnType("date");

                    b.Property<string>("Nombre")
                        .HasMaxLength(80)
                        .HasColumnType("varchar(80)");

                    b.HasKey("Id");

                    b.ToTable("TipoRequerimiento", (string)null);
                });

            modelBuilder.Entity("Core.Entities.Blockchain", b =>
                {
                    b.HasOne("Core.Entities.Auditoria", "Auditorias")
                        .WithMany("Blockchains")
                        .HasForeignKey("IdAuditoria")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.HiloRespuestaNotificacion", "HiloRespuestaNotificaciones")
                        .WithMany("Blockchains")
                        .HasForeignKey("IdHiloRespuesta")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.TipoNotificaciones", "TipoNotificaciones")
                        .WithMany("Blockchains")
                        .HasForeignKey("IdNotificacion")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Auditorias");

                    b.Navigation("HiloRespuestaNotificaciones");

                    b.Navigation("TipoNotificaciones");
                });

            modelBuilder.Entity("Core.Entities.GenericosVsSubmodulos", b =>
                {
                    b.HasOne("Core.Entities.PermisosGenericos", "PermisosGenericos")
                        .WithMany("GenericosVsSubmodulos")
                        .HasForeignKey("IdGenericos")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.Rol", "Roles")
                        .WithMany("GenericosVsSubmodulos")
                        .HasForeignKey("IdRol")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.MaestrosVsSubmodulos", "MaestrosVsSubmodulos")
                        .WithMany("GenericosVsSubmodulos")
                        .HasForeignKey("IdSubModulos")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MaestrosVsSubmodulos");

                    b.Navigation("PermisosGenericos");

                    b.Navigation("Roles");
                });

            modelBuilder.Entity("Core.Entities.MaestrosVsSubmodulos", b =>
                {
                    b.HasOne("Core.Entities.ModulosMaestros", "ModulosMaestros")
                        .WithMany("MaestrosVsSubmodulos")
                        .HasForeignKey("IdMaestro")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.Submodulos", "Submodulos")
                        .WithMany("MaestrosVsSubmodulos")
                        .HasForeignKey("IdSubModulo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ModulosMaestros");

                    b.Navigation("Submodulos");
                });

            modelBuilder.Entity("Core.Entities.ModuloNotificaciones", b =>
                {
                    b.HasOne("Core.Entities.EstadoNotificacion", "EstadoNotificaciones")
                        .WithMany("ModuloNotificaciones")
                        .HasForeignKey("IdEstadoNotificacion")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.Formatos", "Formatos")
                        .WithMany("ModuloNotificaciones")
                        .HasForeignKey("IdFormato")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.HiloRespuestaNotificacion", "HiloRespuestaNotificaciones")
                        .WithMany("ModuloNotificaciones")
                        .HasForeignKey("IdHiloRespuesta")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.Radicados", "Radicados")
                        .WithMany("ModuloNotificaciones")
                        .HasForeignKey("IdRadicado")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.TipoRequerimiento", "TipoRequerimientos")
                        .WithMany("ModuloNotificaciones")
                        .HasForeignKey("IdRequereimiento")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.TipoNotificaciones", "TipoNotificaciones")
                        .WithMany("ModuloNotificaciones")
                        .HasForeignKey("IdTipoNotificacion")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EstadoNotificaciones");

                    b.Navigation("Formatos");

                    b.Navigation("HiloRespuestaNotificaciones");

                    b.Navigation("Radicados");

                    b.Navigation("TipoNotificaciones");

                    b.Navigation("TipoRequerimientos");
                });

            modelBuilder.Entity("Core.Entities.RolVsMaestro", b =>
                {
                    b.HasOne("Core.Entities.ModulosMaestros", "ModulosMaestros")
                        .WithMany("RolVsMaestros")
                        .HasForeignKey("IdMaestro")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.Rol", "Roles")
                        .WithMany("RolVsMaestros")
                        .HasForeignKey("IdRol")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ModulosMaestros");

                    b.Navigation("Roles");
                });

            modelBuilder.Entity("Core.Entities.Auditoria", b =>
                {
                    b.Navigation("Blockchains");
                });

            modelBuilder.Entity("Core.Entities.EstadoNotificacion", b =>
                {
                    b.Navigation("ModuloNotificaciones");
                });

            modelBuilder.Entity("Core.Entities.Formatos", b =>
                {
                    b.Navigation("ModuloNotificaciones");
                });

            modelBuilder.Entity("Core.Entities.HiloRespuestaNotificacion", b =>
                {
                    b.Navigation("Blockchains");

                    b.Navigation("ModuloNotificaciones");
                });

            modelBuilder.Entity("Core.Entities.MaestrosVsSubmodulos", b =>
                {
                    b.Navigation("GenericosVsSubmodulos");
                });

            modelBuilder.Entity("Core.Entities.ModulosMaestros", b =>
                {
                    b.Navigation("MaestrosVsSubmodulos");

                    b.Navigation("RolVsMaestros");
                });

            modelBuilder.Entity("Core.Entities.PermisosGenericos", b =>
                {
                    b.Navigation("GenericosVsSubmodulos");
                });

            modelBuilder.Entity("Core.Entities.Radicados", b =>
                {
                    b.Navigation("ModuloNotificaciones");
                });

            modelBuilder.Entity("Core.Entities.Rol", b =>
                {
                    b.Navigation("GenericosVsSubmodulos");

                    b.Navigation("RolVsMaestros");
                });

            modelBuilder.Entity("Core.Entities.Submodulos", b =>
                {
                    b.Navigation("MaestrosVsSubmodulos");
                });

            modelBuilder.Entity("Core.Entities.TipoNotificaciones", b =>
                {
                    b.Navigation("Blockchains");

                    b.Navigation("ModuloNotificaciones");
                });

            modelBuilder.Entity("Core.Entities.TipoRequerimiento", b =>
                {
                    b.Navigation("ModuloNotificaciones");
                });
#pragma warning restore 612, 618
        }
    }
}
