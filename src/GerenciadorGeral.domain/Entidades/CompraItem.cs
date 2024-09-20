namespace GerenciadorGeral.domain.Entidades
{
  public class CompraItem : EntidadeBase
  {
    public Guid IdCompra { get; set; }
    public Guid IdSku { get; set; }
    public decimal ValorUnitario { get; set; }
    public decimal Quantidade { get; set; }
    public decimal Desconto { get; set; }
    public decimal ValorTotal { get; set; }       
    public virtual Compra Compra { get; set; }    
    public virtual SKU SKU { get; set; }
  }
}
