using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;
public class BlockchainConfiguration : IEntityTypeConfiguration<Blockchain>
{
    public void Configure(EntityTypeBuilder<Blockchain> builder)
    {
        builder.ToTable("Blockchain");

        builder.HasKey(b => b.Id);
        builder.Property(b => b.Id);

        builder.Property(b => b.HasGenerado).HasMaxLength(100);

        builder.Property(b => b.FechaCreacion).HasColumnType("date");

        builder.Property(b => b.FechaModificacion).HasColumnType("date");

        builder.HasOne(b => b.TipoNotificaciones).WithMany(r => r.Blockchains).HasForeignKey(rm => rm.IdNotificacion);

        builder.HasOne(b => b.HiloRespuestaNotificaciones).WithMany(r => r.Blockchains).HasForeignKey(rm => rm.IdHiloRespuesta);

        builder.HasOne(b => b.Auditorias).WithMany(r => r.Blockchains).HasForeignKey(rm => rm.IdAuditoria);
    }
}