using GerenciadorGeral.domain.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorGeral.infra.Data.Mapeamentos
{
  public class CustoProducaoMap : MapBase<CustoProducao>
  {
    public override void Configure(EntityTypeBuilder<CustoProducao> builder)
    {
      base.Configure(builder);
      builder.ToTable("CustoProducao", "dbo");

      builder.Property(c => c.IdUsuario).IsRequired();
      builder.Property(c => c.IdSKU).IsRequired();

      builder.HasOne(c => c.Usuario).WithMany(c => c.CustoProducao).HasForeignKey(c => c.IdUsuario);
      builder.HasOne(c => c.SKU).WithMany(c => c.ListaCustoProducao).HasForeignKey(c => c.IdSKU);
    }
  }
}
