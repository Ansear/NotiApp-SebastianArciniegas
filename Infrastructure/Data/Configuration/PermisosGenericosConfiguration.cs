using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;
public class PermisosGenericosConfiguration : IEntityTypeConfiguration<PermisosGenericos>
{
    public void Configure(EntityTypeBuilder<PermisosGenericos> builder)
    {
        builder.ToTable("PermisosGenericos");

        builder.HasKey(pg => pg.Id);
        builder.Property(pg => pg.Id);

        builder.Property(pg => pg.NombrePermiso);

        builder.Property(pg => pg.FechaCreacion).HasColumnType("date");

        builder.Property(pg => pg.FechaModificacion).HasColumnType("date");
    }
}