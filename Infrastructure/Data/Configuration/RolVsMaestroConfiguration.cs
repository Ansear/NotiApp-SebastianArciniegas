using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;
public class RolVsMaestroConfiguration : IEntityTypeConfiguration<RolVsMaestro>
{
    public void Configure(EntityTypeBuilder<RolVsMaestro> builder)
    {
        builder.ToTable("RolVsMaestro");

        builder.HasKey(rm => rm.Id);
        builder.Property(rm => rm.Id);

        builder.HasOne(rm => rm.Roles).WithMany(r => r.RolVsMaestros).HasForeignKey(rm => rm.IdRol);

        builder.HasOne(rm => rm.ModulosMaestros).WithMany(r => r.RolVsMaestros).HasForeignKey(rm => rm.IdMaestro);

        builder.Property(rm => rm.FechaCreacion).HasColumnType("date");

        builder.Property(rm => rm.FechaModificacion).HasColumnType("date");
    }
}