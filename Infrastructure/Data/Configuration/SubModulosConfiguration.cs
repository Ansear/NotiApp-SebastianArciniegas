using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;
public class SubModulosConfiguration : IEntityTypeConfiguration<Submodulos>
{
    public void Configure(EntityTypeBuilder<Submodulos> builder)
    {
        builder.ToTable("SubModulos");

        builder.HasKey(sm => sm.Id);
        builder.Property(sm => sm.Id);

        builder.Property(sm => sm.NombreSubModulo).HasMaxLength(80);

        builder.Property(sm => sm.FechaCreacion).HasColumnType("date");

        builder.Property(sm => sm.FechaModificacion).HasColumnType("date");
    }
}