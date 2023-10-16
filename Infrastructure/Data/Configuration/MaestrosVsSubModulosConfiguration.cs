using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;
    public class MaestrosVsSubModulosConfiguration : IEntityTypeConfiguration<MaestrosVsSubmodulos>
    {
        public void Configure(EntityTypeBuilder<MaestrosVsSubmodulos> builder)
        {
            builder.ToTable("MaestrosVsSubmodulos");

            builder.HasKey(ms => ms.Id);
            builder.Property(ms => ms.Id);

            builder.Property(ms => ms.FechaCreacion).HasColumnType("date");

            builder.Property(ms => ms.FechaModificacion).HasColumnType("date");

            builder.HasOne(ms => ms.ModulosMaestros).WithMany(m => m.MaestrosVsSubmodulos).HasForeignKey(ms => ms.IdMaestro);

            builder.HasOne(ms => ms.Submodulos).WithMany(sm => sm.MaestrosVsSubmodulos).HasForeignKey(ms => ms.IdSubModulo);
        }
    }