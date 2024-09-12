using AutoMapper;
using GerenciadorGeral.application.DTO;
using GerenciadorGeral.application.Interfaces;
using GerenciadorGeral.domain.Entidades;
using GerenciadorGeral.domain.Interfaces.Servicos;

namespace GerenciadorGeral.application.Servicos
{
    public class CompraItemApp : AppBase<CompraItem, CompraItemDTO>, ICompraItemApp
    {
        protected readonly ICompraItemServico _servico;
        protected readonly IMapper _iMapper;
        public CompraItemApp(IMapper iMapper, ICompraItemServico servico) : base(iMapper, servico)
        {
            this._iMapper = iMapper;
            this._servico = servico;
        }
    }
}
