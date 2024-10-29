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
      builder.Property(c => c.CodigoUnidadeMedida).IsRequired().HasColumnName("CodigoUnidadeMedida").HasMaxLength(5).HasColumnType("varchar");

      builder.HasOne(c => c.Marca).WithMany(c => c.SKUs).HasForeignKey(c => c.IdMarca);
      builder.HasOne(c => c.UnidadeMedida).WithMany(c => c.SKUs).HasForeignKey(c => c.CodigoUnidadeMedida);
      builder.HasOne(c => c.Insumo).WithMany(c => c.ListaSKU).HasForeignKey(c => c.IdInsumo);
    }
  }
}
