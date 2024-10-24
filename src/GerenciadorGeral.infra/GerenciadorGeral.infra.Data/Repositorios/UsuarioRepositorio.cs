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
  public class UsuarioRepositorio : RepositorioBase<Usuario>, IUsuarioRepositorio
  {
    public UsuarioRepositorio(Contexto context) : base(context)
    {
    }
  }
}
