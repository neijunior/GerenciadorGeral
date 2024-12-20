﻿using GerenciadorGeral.application.DTO;
using GerenciadorGeral.domain.Entidades;

namespace GerenciadorGeral.application.Interfaces
{
  public interface ICustoProducaoDetalheApp : IAppBase<CustoProducaoDetalhe, CustoProducaoDetalheDTO>
  {
    Task<RetornoDTO> Salvar(CustoProducaoDetalheDTO detalhe);
    Task<ICollection<CustoProducaoDetalheDTO>> AtualizarValoresCusto(Guid IdCustoProducao);
    Task<CustoProducaoDetalhe> PopularDetalhe(CustoProducaoDetalheDTO custoProducaoDetalhe);
  }
}
