using GerenciadorGeral.domain.Entidades;
using GerenciadorGeral.domain.Interfaces.Repositorios;
using GerenciadorGeral.infra.Data.Contextos;

namespace GerenciadorGeral.infra.Data.Repositorios
{
  public class SKURepositorio : RepositorioBase<SKU>, ISKURepositorio
  {
    public SKURepositorio(Contexto context) : base(context)
    {
    }
  }
}
