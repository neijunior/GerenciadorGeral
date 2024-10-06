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
  //public class CompraMap : MapBase<Compra>
  //{
  //  public override void Configure(EntityTypeBuilder<Compra> builder)
  //  {
  //    base.Configure(builder);
  //    builder.ToTable("Compra", "dbo");

  //    builder.Property(c => c.IdFornecedor).IsRequired();
      
  //    //builder.Property(c => c.UnidadeMedida).IsRequired().HasColumnName("UnidadeMedida").HasMaxLength(5).HasColumnType("varchar");

  //    builder.HasOne(c => c.Fornecedor).WithMany(c => c.Compras).HasForeignKey(c => c.IdFornecedor);
  //  }
  //}
}
