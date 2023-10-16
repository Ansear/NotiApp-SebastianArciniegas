using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;
public class RolConfiguration : IEntityTypeConfiguration<Rol>
{
    public void Configure(EntityTypeBuilder<Rol> builder)
    {
        builder.ToTable("Rol");

        builder.HasKey(r => r.Id);
        builder.Property(r => r.Id);

        builder.Property(r => r.Nombre).IsRequired().HasMaxLength(40);

        builder.Property(r => r.FechaCreacion).HasColumnType("date");

        builder.Property(r => r.FechaModificacion).HasColumnType("date");
    }
}