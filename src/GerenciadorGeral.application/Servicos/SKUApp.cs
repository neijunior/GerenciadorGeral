using AutoMapper;
using GerenciadorGeral.application.DTO;
using GerenciadorGeral.application.Interfaces;
using GerenciadorGeral.domain.Entidades;
using GerenciadorGeral.domain.Interfaces.Servicos;

namespace GerenciadorGeral.application.Servicos
{
  public class SKUApp : AppBase<SKU, SKUDTO>, ISKUApp
  {
    public SKUApp(IMapper iMapper, ISKUServico servico) : base(iMapper, servico)
    {
    }

    public async Task<ICollection<SKUDTO>> ListarProdutoInterno()
    {
      var listaProdutoInterno = await _servicoBase.Listar<SKU>(w => w.Interno.HasValue && w.Interno.Value);
      return _iMapperBase.Map<ICollection<SKUDTO>>(listaProdutoInterno);
    }
  }
}
