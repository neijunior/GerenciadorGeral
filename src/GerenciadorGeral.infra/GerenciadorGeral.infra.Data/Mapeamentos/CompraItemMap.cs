using GerenciadorGeral.domain.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GerenciadorGeral.infra.Data.Mapeamentos
{
  public class CompraItemMap : MapBase<CompraItem>
  {
    public override void Configure(EntityTypeBuilder<CompraItem> builder)
    {
      base.Configure(builder);
      builder.ToTable("CompraItem", "dbo");
      
      builder.HasOne(c => c.Compra).WithMany(c => c.ListaItens).HasForeignKey(c => c.IdCompra);
      builder.HasOne(c => c.SKU).WithMany(c => c.ListaItens).HasForeignKey(c => c.IdSku);

    }
  }
}
