using GerenciadorGeral.domain.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GerenciadorGeral.infra.Data.Mapeamentos
{
  public class CustoProducaoDetalheMap : MapBase<CustoProducaoDetalhe>
  {
    public override void Configure(EntityTypeBuilder<CustoProducaoDetalhe> builder)
    {
      base.Configure(builder);
      builder.ToTable("CustoProducaoDetalhe", "dbo");

      builder.Property(c => c.IdCustoProducao).IsRequired();
      //builder.Property(c => c.IdInsumo).IsRequired();
      builder.Property(c => c.QuantidadeUtilizada).IsRequired().HasColumnType("decimal(8,4)");

      builder.HasOne(c => c.CustoProducao).WithMany(c => c.ListaProducaoDetalhe).HasForeignKey(c => c.IdCustoProducao);
      builder.HasOne(c => c.Insumo).WithMany(c => c.ListaCustoProducaoDetalhe).HasForeignKey(c => c.IdInsumo).OnDelete(DeleteBehavior.Restrict);
      builder.HasOne(c => c.SKU).WithMany(c => c.ListaCustoProducaoDetalhe).HasForeignKey(c => c.IdSKU).OnDelete(DeleteBehavior.Restrict);

    }
  }
}
