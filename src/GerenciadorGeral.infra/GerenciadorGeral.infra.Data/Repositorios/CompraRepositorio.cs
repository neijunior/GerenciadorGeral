using GerenciadorGeral.domain.Entidades;
using GerenciadorGeral.domain.Interfaces.Repositorios;
using GerenciadorGeral.infra.Data.Contextos;

namespace GerenciadorGeral.infra.Data.Repositorios
{
    public class CompraRepositorio : RepositorioBase<Compra>, ICompraRepositorio
    {
        public CompraRepositorio(Contexto context) : base(context)
        {
        }
    }
}
