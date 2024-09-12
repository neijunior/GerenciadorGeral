using GerenciadorGeral.domain.Entidades;
using GerenciadorGeral.domain.Interfaces.Repositorios;
using GerenciadorGeral.domain.Interfaces.Servicos;

namespace GerenciadorGeral.domain.Servicos
{
    public class CompraItemServico : ServicoBase<CompraItem>, ICompraItemServico
    {
        public CompraItemServico(ICompraItemRepositorio repositorio) : base(repositorio)
        {
        }
    }
}
