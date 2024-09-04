using AutoMapper;
using GerenciadorGeral.application.DTO;
using GerenciadorGeral.application.Interfaces;
using GerenciadorGeral.domain.Entidades;
using GerenciadorGeral.domain.Interfaces.Servicos;

namespace GerenciadorGeral.application.Servicos
{
    public class FornecedorApp : ServicoAppBase<Fornecedor, FornecedorDTO>, IFornecedorApp
    {
        public FornecedorApp(IMapper iMapper, IFornecedorServico servico) : base(iMapper, servico)
        {
        }
    }    
}
