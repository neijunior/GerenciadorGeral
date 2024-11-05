using GerenciadorGeral.domain.Entidades;

namespace GerenciadorGeral.domain.Interfaces.Servicos
{
  public interface ICustoProducaoDetalheServico : IServicoBase<CustoProducaoDetalhe>
  {
    Task SalvarLista(ICollection<CustoProducaoDetalhe> lista);
  }
}
