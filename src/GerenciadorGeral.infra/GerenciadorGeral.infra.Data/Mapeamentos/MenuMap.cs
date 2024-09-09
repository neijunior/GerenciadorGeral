using GerenciadorGeral.domain.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GerenciadorGeral.infra.Data.Mapeamentos
{
  public class MenuMap : MapBase<Menu>
  {
    public override void Configure(EntityTypeBuilder<Menu> builder)
    {
      base.Configure(builder);
      builder.ToTable("Menu", "dbo");
      builder.Property(c => c.Titulo).IsRequired().HasColumnName("Titulo").HasMaxLength(75).HasColumnType("varchar");
    }
  }
}
