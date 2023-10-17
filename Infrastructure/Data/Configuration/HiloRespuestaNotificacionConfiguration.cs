using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;
public class HiloRespuestaNotificacionConfiguration : BaseEntity
{
    public void Configure(EntityTypeBuilder<HiloRespuestaNotificacion> builder)
    {
        builder.ToTable("HiloRespuestaNotificacion");

        builder.HasKey(ms => ms.Id);
        builder.Property(ms => ms.Id);

        builder.Property(h => h.NombreTipo).HasMaxLength(80);

        builder.Property(r => r.FechaCreacion).HasColumnType("date");

        builder.Property(r => r.FechaModificacion).HasColumnType("date");
    }
}