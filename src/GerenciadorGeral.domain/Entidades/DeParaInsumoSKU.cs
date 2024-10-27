using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorGeral.domain.Entidades
{
  public class DeParaInsumoSKU : EntidadeBase
  {
    public Guid IdSKU { get; set; }
    public Guid IdInsumo { get; set; }
    public virtual SKU SKU { get; set; }
    public virtual Insumo Insumo { get; set; }
  }
}
