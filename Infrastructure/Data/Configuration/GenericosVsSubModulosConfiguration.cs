using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;
public class GenericosVsSubModulosConfiguration : IEntityTypeConfiguration<GenericosVsSubmodulos>
{
    public void Configure(EntityTypeBuilder<GenericosVsSubmodulos> builder)
    {
        builder.ToTable("GenericosVsSubmodulos");
    
        builder.HasKey(gs => gs.Id);
        builder.Property(gs => gs.Id);

        builder.Property(gs => gs.FechaCreacion).HasColumnType("date");

        builder.Property(gs => gs.FechaModificacion).HasColumnType("date");

        builder.HasOne(gs => gs.PermisosGenericos).WithMany(pg => pg.GenericosVsSubmodulos).HasForeignKey(ms => ms.IdGenericos);

        builder.HasOne(gs => gs.MaestrosVsSubmodulos).WithMany(ms => ms.GenericosVsSubmodulos).HasForeignKey(ms => ms.IdSubModulos);

        builder.HasOne(gs => gs.Roles).WithMany(r => r.GenericosVsSubmodulos).HasForeignKey(gs => gs.IdRol);
    }
}