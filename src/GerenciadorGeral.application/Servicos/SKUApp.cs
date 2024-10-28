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

    public async Task<ICollection<SKUDTO>> Listar(bool? interno)
    {
      var listaSku = await _servicoBase.Listar<SKU>(w => !interno.HasValue || (w.Interno.HasValue && (w.Interno.Value == interno.Value)));
      return _iMapperBase.Map<ICollection<SKUDTO>>(listaSku);
    }

    public async Task<ICollection<SKUDTO>> ListarProdutos(ICollection<Guid> ids)
    {
      var listaProdutoInterno = await _servicoBase.Listar<SKU>(w => ids.Contains(w.Id));
      return _iMapperBase.Map<ICollection<SKUDTO>>(listaProdutoInterno);
    }
  }
}
