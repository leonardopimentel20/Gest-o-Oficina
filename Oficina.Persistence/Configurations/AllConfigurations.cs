using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Oficina.Domain.Entities;
namespace Oficina.Persistence.Configurations;

public static class EntityConfigurationExtensions {
    public static void ConfigureCommon<TEntity>(this EntityTypeBuilder<TEntity> b) where TEntity : BaseEntity {
        b.HasKey(x => x.Id); b.Property(x => x.Id).ValueGeneratedNever();
        b.Property(x => x.CriadoEm).HasDefaultValueSql("CURRENT_TIMESTAMP");
    }
}
