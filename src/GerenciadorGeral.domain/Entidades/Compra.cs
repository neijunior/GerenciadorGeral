namespace GerenciadorGeral.domain.Entidades
{
  public class Compra : EntidadeBase
  {
    public Guid IdFornecedor { get; set; }    
    public decimal Desconto { get; set; }
    public decimal ValorTotal { get; set; }
    public DateTime Data { get; set; }
    public string? Observacao { get; set; }
    public virtual ICollection<CompraItem> ListaItens { get; set; }
    public virtual Fornecedor? Fornecedor { get; set; }
  }
}
