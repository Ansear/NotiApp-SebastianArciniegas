using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;
public class AuditoriaConfiguration : IEntityTypeConfiguration<Auditoria>
{
    public void Configure(EntityTypeBuilder<Auditoria> builder)
    {
        builder.ToTable("Auditoria");

        builder.HasKey(a => a.Id);
        builder.Property(a => a.Id);

        builder.Property(a => a.NombreUsuario).HasMaxLength(100);

        builder.Property(a => a.DescAccion);

        builder.Property(r => r.FechaCreacion).HasColumnType("date");

        builder.Property(r => r.FechaModificacion).HasColumnType("date");
    }
}