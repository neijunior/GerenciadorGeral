using GerenciadorGeral.domain.Entidades;
using Microsoft.EntityFrameworkCore;
using System;

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
      modelBuilder.Entity<UnidadeMedida>().HasData(new UnidadeMedida() { Codigo = "KG", Descricao = "Quilograma" },
      new UnidadeMedida() { Codigo = "G", Descricao = "Grama" },
      new UnidadeMedida() { Codigo = "UN", Descricao = "Unidade" },
      new UnidadeMedida() { Codigo = "L", Descricao = "Litro" },
      new UnidadeMedida() { Codigo = "ML", Descricao = "Mililitro" });
    }
  }
}
