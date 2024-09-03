using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorGeral.domain.Entidades
{
  public class Produto : EntidadeBase
  {
    public string Codigo { get; set; }
    public string Nome { get; set; }  
    public string Observacao { get; set; }  
    public bool Ativo { get; set; }
  }
}
