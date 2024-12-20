﻿using GerenciadorGeral.domain.Entidades;
using GerenciadorGeral.domain.Interfaces.Repositorios;
using GerenciadorGeral.infra.Data.Contextos;

namespace GerenciadorGeral.infra.Data.Repositorios
{
  public class MarcaRepositorio : RepositorioBase<Marca>, IMarcaRepositorio
  {
    public MarcaRepositorio(Contexto context) : base(context)
    {
    }
  }
}
