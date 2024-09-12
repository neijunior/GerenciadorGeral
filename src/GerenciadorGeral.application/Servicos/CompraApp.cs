using AutoMapper;
using GerenciadorGeral.application.DTO;
using GerenciadorGeral.application.Interfaces;
using GerenciadorGeral.domain.Entidades;
using GerenciadorGeral.domain.Interfaces.Servicos;

namespace GerenciadorGeral.application.Servicos
{
  public class CompraApp : AppBase<Compra, CompraDTO>, ICompraApp
  {
    protected readonly ICompraServico _servico;
    protected readonly ICompraItemServico _compraItem;
    protected readonly IMapper _iMapper;
    public CompraApp(IMapper iMapper, ICompraServico servico, ICompraItemServico compraItemServico) : base(iMapper, servico)
    {
      this._iMapper = iMapper;
      this._servico = servico;
      this._compraItem = compraItemServico;
    }

    public async Task<CompraDTO> Consultar(Guid Id)
    {
      var item = await this._servico.Consultar(Id);

      return this._iMapper.Map<CompraDTO>(item);  

    }
  }
}
