using GerenciadorGeral.domain.Entidades;
using GerenciadorGeral.domain.Interfaces.Repositorios;
using GerenciadorGeral.infra.Data.Contextos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorGeral.infra.Data.Repositorios
{
  public class MarcaRepositorio : RepositorioBase<Marca>, IMarcaRepositorio
  {
    public MarcaRepositorio(Contexto context) : base(context)
    {
    }
  }
}
