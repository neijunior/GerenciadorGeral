using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorGeral.domain.Entidades
{
  public class CustoProducaoDetalhe : EntidadeBase
  {
    public Guid IdCustoProducao { get; set; }
    public Guid IdSKU { get; set; }
    public decimal qtdUtilizada { get; set; }
    public decimal CustoAquisicaoItem { get; set; }
    public decimal ValorCustoProducao { get; set; }
    public virtual CustoProducao CustoProducao { get; set; }
    public virtual SKU SKU { get; set; }
  }
}
