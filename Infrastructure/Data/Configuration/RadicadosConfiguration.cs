using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;
public class RadicadosConfiguration : IEntityTypeConfiguration<Radicados>
{
    public void Configure(EntityTypeBuilder<Radicados> builder)
    {
        builder.ToTable("Radicados");
        
        builder.HasKey(r => r.Id);
        builder.Property(r => r.Id);

        builder.Property(r => r.FechaCreacion).HasColumnType("date");

        builder.Property(r => r.FechaModificacion).HasColumnType("date");
    }
}