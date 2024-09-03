using GerenciadorGeral.domain.Entidades;
using GerenciadorGeral.domain.Interfaces.Repositorios;
using GerenciadorGeral.domain.Interfaces.Servicos;

namespace GerenciadorGeral.domain.Servicos
{
  public class SKUServico : ServicoBase<SKU>, ISKUServico
  {
    public SKUServico(ISKURepositorio repositorio) : base(repositorio)
    {

    }
  }
}
