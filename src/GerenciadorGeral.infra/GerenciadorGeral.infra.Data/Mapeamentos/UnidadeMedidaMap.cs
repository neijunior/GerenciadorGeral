using GerenciadorGeral.domain.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GerenciadorGeral.infra.Data.Mapeamentos
{
  public class UnidadeMedidaMap : MapBase<UnidadeMedida>
  {
    public override void Configure(EntityTypeBuilder<UnidadeMedida> builder)
    {
      base.Configure(builder);
      builder.ToTable("UnidadeMedida", "dbo");
      builder.Property(c => c.Codigo).IsRequired().HasColumnName("Codigo").HasMaxLength(5).HasColumnType("varchar");
      builder.Property(c => c.Descricao).IsRequired().HasColumnName("Descricao").HasMaxLength(100).HasColumnType("varchar");
    }
  }
}
