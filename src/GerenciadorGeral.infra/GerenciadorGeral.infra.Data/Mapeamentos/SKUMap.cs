using GerenciadorGeral.domain.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GerenciadorGeral.infra.Data.Mapeamentos
{
  public class SKUMap : MapBase<SKU>
  {
    public override void Configure(EntityTypeBuilder<SKU> builder)
    {
      base.Configure(builder);
      builder.ToTable("SKU", "dbo");
      builder.Property(c => c.Nome).IsRequired().HasColumnName("Nome").HasMaxLength(100).HasColumnType("varchar");
      builder.Property(c => c.UnidadeMedida).IsRequired().HasColumnName("UnidadeMedida").HasMaxLength(5).HasColumnType("varchar");
    }
  }
}
