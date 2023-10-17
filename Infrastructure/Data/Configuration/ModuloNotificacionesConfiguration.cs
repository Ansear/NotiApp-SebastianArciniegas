using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;
public class ModuloNotificacionesConfiguration : IEntityTypeConfiguration<ModuloNotificaciones>
{
    public void Configure(EntityTypeBuilder<ModuloNotificaciones> builder)
    {
        builder.ToTable("ModuloNotificaciones");

        builder.HasKey(r => r.Id);
        builder.Property(r => r.Id);

        builder.Property(mn => mn.AsuntoNotificacion).HasMaxLength(80);

        builder.HasOne(mn => mn.TipoNotificaciones).WithMany(r => r.ModuloNotificaciones).HasForeignKey(rm => rm.IdTipoNotificacion);

        builder.HasOne(mn => mn.Radicados).WithMany(r => r.ModuloNotificaciones).HasForeignKey(rm => rm.IdRadicado);

        builder.HasOne(mn => mn.EstadoNotificaciones).WithMany(r => r.ModuloNotificaciones).HasForeignKey(rm => rm.IdEstadoNotificacion);

        builder.HasOne(mn => mn.HiloRespuestaNotificaciones).WithMany(r => r.ModuloNotificaciones).HasForeignKey(rm => rm.IdHiloRespuesta);

        builder.HasOne(mn => mn.Formatos).WithMany(r => r.ModuloNotificaciones).HasForeignKey(rm => rm.IdFormato);

        builder.HasOne(mn => mn.TipoRequerimientos).WithMany(r => r.ModuloNotificaciones).HasForeignKey(rm => rm.IdRequereimiento);

        builder.Property(mn => mn.TextoNotificacion).HasMaxLength(2000);

        builder.Property(r => r.FechaCreacion).HasColumnType("date");

        builder.Property(r => r.FechaModificacion).HasColumnType("date");
    }
}