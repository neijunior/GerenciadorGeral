﻿using GerenciadorGeral.domain.Entidades;

namespace GerenciadorGeral.domain.Interfaces.Servicos
{
  public interface ICompraServico  : IServicoBase<Compra>
  {
    Task<Compra> Consultar(Guid Id);
  }
}
