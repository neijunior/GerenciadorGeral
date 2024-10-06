using GerenciadorGeral.domain.Entidades;
using GerenciadorGeral.domain.Interfaces.Repositorios;
using GerenciadorGeral.infra.Data.Contextos;

namespace GerenciadorGeral.infra.Data.Repositorios
{
    public class CompraItemRepositorio : RepositorioBase<CompraItem>, ICompraItemRepositorio
    {
        public CompraItemRepositorio(Contexto context) : base(context)
        {
        }
    }
}
