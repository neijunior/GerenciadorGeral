using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorGeral.domain.Entidades
{
  public class Insumo : EntidadeBase
  {
    public string Nome { get; set; }
    public virtual ICollection<DeParaInsumoSKU> ListaDeParaInsumoSKU { get; set; }
  }
}
