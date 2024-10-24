﻿using GerenciadorGeral.domain.Entidades;

namespace GerenciadorGeral.domain.Interfaces.Servicos
{
  public  interface ICustoProducaoServico : IServicoBase<CustoProducao>
  {
    Task<CustoProducao> Consultar(Guid Id);
  }
}
