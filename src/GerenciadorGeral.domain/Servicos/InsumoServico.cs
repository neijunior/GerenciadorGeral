using GerenciadorGeral.domain.Entidades;
using GerenciadorGeral.domain.Interfaces.Repositorios;
using GerenciadorGeral.domain.Interfaces.Servicos;

namespace GerenciadorGeral.domain.Servicos
{
  public class InsumoServico : ServicoBase<Insumo>, IInsumoServico
  {
    protected IInsumoRepositorio _repositorio;  
    
    public InsumoServico(IInsumoRepositorio repositorio) : base(repositorio)
    {
      this._repositorio = repositorio;
    }

    public async Task<Insumo> Consultar(Guid Id)
    {
      return await _repositorio.Consultar<Insumo>(w => w.Id == Id, i => i.ListaSKU);      
    }
  }
}
