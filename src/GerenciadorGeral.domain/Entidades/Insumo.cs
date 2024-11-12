namespace GerenciadorGeral.domain.Entidades
{
  public class Insumo : EntidadeBase
  {
    public string Nome { get; set; }
    public string CodigoUnidadeMedida { get; set; }
    public bool ProducaoPropria { get; set; }
    public virtual UnidadeMedida? UnidadeMedida { get; set; }
    public virtual ICollection<SKU> ListaSKU { get; set; }
    public virtual ICollection<CustoProducaoDetalhe> ListaCustoProducaoDetalhe { get; set; }
  }
}
