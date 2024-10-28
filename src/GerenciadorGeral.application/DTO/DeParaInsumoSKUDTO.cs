using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorGeral.application.DTO
{
  public class DeParaInsumoSKUDTO : BaseDTO
  {
    public Guid IdSKU { get; set; }
    public Guid IdInsumo { get; set; }
    public SKUDTO SKU { get; set; }
    public InsumoDTO Insumo { get; set; }
  }
}
