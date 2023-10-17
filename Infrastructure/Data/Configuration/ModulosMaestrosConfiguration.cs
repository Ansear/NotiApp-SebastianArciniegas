
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;
public class ModulosMaestrosConfiguration : IEntityTypeConfiguration<ModulosMaestros>
{
    public void Configure(EntityTypeBuilder<ModulosMaestros> builder)
    {
        builder.ToTable("ModulosMaestros");

        builder.HasKey(mm => mm.Id);
        builder.Property(mm => mm.Id);

        builder.Property(mm => mm.NombreModulo).HasMaxLength(100);

        builder.Property(mm => mm.FechaCreacion).HasColumnType("date");

        builder.Property(mm => mm.FechaModificacion).HasColumnType("date");
    }
}