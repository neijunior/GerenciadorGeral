using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorGeral.application.DTO
{
  public class CustoProducaoDTO : BaseDTO
  {
    public SKUDTO skuDTO { get; set; }    
    public decimal qtd { get; set; }
    public decimal valorCompra { get; set; }
    public decimal valorCustoProducao { get; set; }
  }
}
