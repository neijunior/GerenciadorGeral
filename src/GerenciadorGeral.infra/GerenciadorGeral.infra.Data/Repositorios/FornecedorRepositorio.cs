using GerenciadorGeral.domain.Entidades;
using GerenciadorGeral.domain.Interfaces.Repositorios;
using GerenciadorGeral.infra.Data.Contextos;

namespace GerenciadorGeral.infra.Data.Repositorios
{
    public class FornecedorRepositorio : RepositorioBase<Fornecedor>, IFornecedorRepositorio
    {
        public FornecedorRepositorio(Contexto context) : base(context)
        {
        }
    }
}
