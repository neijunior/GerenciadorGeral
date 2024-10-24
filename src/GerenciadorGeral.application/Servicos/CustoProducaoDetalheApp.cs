using AutoMapper;
using GerenciadorGeral.application.DTO;
using GerenciadorGeral.application.Interfaces;
using GerenciadorGeral.domain.Entidades;
using GerenciadorGeral.domain.Interfaces.Servicos;
using System.Collections.Generic;

namespace GerenciadorGeral.application.Servicos
{
  public class CustoProducaoDetalheApp :AppBase<CustoProducaoDetalhe, CustoProducaoDetalheDTO>, ICustoProducaoDetalheApp
  {
    protected readonly ICustoProducaoDetalheServico _servicoCustoProducaoDetalhe;
    protected readonly IMapper _iMapper;
    public CustoProducaoDetalheApp(IMapper iMapper, ICustoProducaoDetalheServico servicoCustoProducaoDetalhe) : base(iMapper, servicoCustoProducaoDetalhe)
    {
      this._iMapper = iMapper;
      this._servicoCustoProducaoDetalhe = servicoCustoProducaoDetalhe;
    }

  }
}
