﻿namespace GerenciadorGeral.application.DTO
{
  public class CustoProducaoDetalheDTO : BaseDTO
  {
    public Guid IdCustoProducao { get; set; }
    public Guid IdSKU { get; set; }
    public decimal qtdUtilizada { get; set; }
    public decimal CustoAquisicaoItem { get; set; }
    public decimal ValorCustoProducao { get; set; }
    public virtual CustoProducaoDTO CustoProducao { get; set; }
    public virtual SKUDTO SKU { get; set; }
  }
}
