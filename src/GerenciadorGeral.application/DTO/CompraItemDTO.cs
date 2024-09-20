namespace GerenciadorGeral.application.DTO
{
  public class CompraItemDTO : BaseDTO
  {
    public Guid IdCompra { get; set; }
    public Guid IdSku { get; set; }    
    public decimal ValorUnitario { get; set; }
    public decimal Quantidade { get; set; }
    public decimal Desconto { get; set; }
    public decimal ValorTotal { get; set; }
    public CompraDTO Compra { get; set; }
    public SKUDTO SKU { get; set; }
  }
}
