﻿namespace GerenciadorGeral.domain.Entidades
{
  public class UnidadeMedida
  {
    public UnidadeMedida()
    {
      Codigo = string.Empty;
      Descricao = string.Empty;
    }
    public string Codigo { get; set; }
    public string Descricao { get; set; }
    public virtual ICollection<SKU> SKUs { get; set; }
    public virtual ICollection<Insumo> Insumos { get; set; }
  }
}
