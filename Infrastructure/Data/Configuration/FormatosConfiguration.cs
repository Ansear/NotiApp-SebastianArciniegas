using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;
public class FormatosConfiguration : IEntityTypeConfiguration<Formatos>
{
    public void Configure(EntityTypeBuilder<Formatos> builder)
    {
        builder.ToTable("Formatos");

        builder.HasKey(ms => ms.Id);
        builder.Property(ms => ms.Id);

        builder.Property(f => f.NombreFormato).HasMaxLength(50);

        builder.Property(r => r.FechaCreacion).HasColumnType("date");

        builder.Property(r => r.FechaModificacion).HasColumnType("date");
    }
}