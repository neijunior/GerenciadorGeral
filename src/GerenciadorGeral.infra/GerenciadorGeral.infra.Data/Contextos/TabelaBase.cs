using GerenciadorGeral.domain.Entidades;
using Microsoft.EntityFrameworkCore;

namespace GerenciadorGeral.infra.Data.Contextos
{
  public static class TabelaBase
  {
    public static void PopularTabela(this ModelBuilder modelBuilder)
    {
      modelBuilder.PopularTabelaUnidadeMedida();
    }

    private static void PopularTabelaUnidadeMedida(this ModelBuilder modelBuilder)
    {
      modelBuilder.Entity<UnidadeMedida>().HasData(new UnidadeMedida() { Id = 1, Codigo = "KG", Descricao = "Quilograma" },
      new UnidadeMedida() { Id = 2, Codigo = "G", Descricao = "Grama" },
      new UnidadeMedida() { Id = 3, Codigo = "UN", Descricao = "Unidade" },
      new UnidadeMedida() { Id = 4, Codigo = "L", Descricao = "Litro" },
      new UnidadeMedida() { Id = 5, Codigo = "ML", Descricao = "Mililitro" });
    }
  }
}
