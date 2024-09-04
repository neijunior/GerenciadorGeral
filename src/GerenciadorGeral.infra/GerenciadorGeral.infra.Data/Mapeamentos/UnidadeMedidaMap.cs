using GerenciadorGeral.domain.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GerenciadorGeral.infra.Data.Mapeamentos
{
    public class UnidadeMedidaMap : IEntityTypeConfiguration<UnidadeMedida>
    {
        public void Configure(EntityTypeBuilder<UnidadeMedida> builder)
        {
            builder.ToTable("UnidadeMedida", "dbo");

            builder.Property(c => c.Codigo).IsRequired().HasColumnName("Codigo").HasMaxLength(5).HasColumnType("varchar");
            builder.Property(c => c.Descricao).IsRequired().HasColumnName("Descricao").HasMaxLength(100).HasColumnType("varchar");

            builder.HasKey(c => c.Codigo);
        }
    }
}
