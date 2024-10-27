using GerenciadorGeral.domain.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GerenciadorGeral.infra.Data.Mapeamentos
{
  public class IsnsumoMap : MapBase<Insumo>
  {
    public override void Configure(EntityTypeBuilder<Insumo> builder)
    {
      base.Configure(builder);
      builder.ToTable("Insumo", "dbo");      
    }
  }
}
