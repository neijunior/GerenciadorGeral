using GerenciadorGeral.domain.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GerenciadorGeral.infra.Data.Mapeamentos
{
  public class DeParaInsumoSKUMap : MapBase<DeParaInsumoSKU>
  {
    public override void Configure(EntityTypeBuilder<DeParaInsumoSKU> builder)
    {
      base.Configure(builder);
      builder.ToTable("DeParaInsumoSKU", "dbo");

      builder.Property(c => c.IdInsumo).IsRequired();
      builder.Property(c => c.IdSKU).IsRequired();

      builder.HasOne(c => c.Insumo).WithMany(c => c.ListaDeParaInsumoSKU).HasForeignKey(c => c.IdInsumo).OnDelete(DeleteBehavior.Restrict);
      builder.HasOne(c => c.SKU).WithMany(c => c.ListaDeParaInsumoSKU).HasForeignKey(c => c.IdSKU).OnDelete(DeleteBehavior.Restrict);
    }
  }
}
