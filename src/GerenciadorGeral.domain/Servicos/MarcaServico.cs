using GerenciadorGeral.domain.Entidades;
using GerenciadorGeral.domain.Interfaces.Repositorios;
using GerenciadorGeral.domain.Interfaces.Servicos;

namespace GerenciadorGeral.domain.Servicos
{
  public class MarcaServico : ServicoBase<Marca>, IMarcaServico
  {
    public MarcaServico(IMarcaRepositorio repositorio) : base(repositorio)
    {

    }
  }
}
