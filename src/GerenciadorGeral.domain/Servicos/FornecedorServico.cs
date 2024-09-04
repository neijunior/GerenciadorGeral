using GerenciadorGeral.domain.Entidades;
using GerenciadorGeral.domain.Interfaces.Repositorios;
using GerenciadorGeral.domain.Interfaces.Servicos;

namespace GerenciadorGeral.domain.Servicos
{
    public class FornecedorServico : ServicoBase<Fornecedor>, IFornecedorServico
    {
        public FornecedorServico(IFornecedorRepositorio repositorio) : base(repositorio)
        {

        }
    }
}
