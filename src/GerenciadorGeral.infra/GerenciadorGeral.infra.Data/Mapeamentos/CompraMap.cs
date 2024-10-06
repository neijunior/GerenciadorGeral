using GerenciadorGeral.domain.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GerenciadorGeral.infra.Data.Mapeamentos
{
  public class CompraMap : MapBase<Compra>
  {
    public override void Configure(EntityTypeBuilder<Compra> builder)
    {
      base.Configure(builder);
      builder.ToTable("Compra", "dbo");

      builder.Property(c => c.IdFornecedor).IsRequired();      

      builder.HasOne(c => c.Fornecedor).WithMany(c => c.Compras).HasForeignKey(c => c.IdFornecedor);
    }
  }
}
