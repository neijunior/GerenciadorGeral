﻿using GerenciadorGeral.application.DTO;

namespace GerenciadorGeral.application.Interfaces
{
  public interface IUnidadeMedidaApp
  {
    Task<ICollection<UnidadeMedidaDTO>> SelectAll();
  }
}
