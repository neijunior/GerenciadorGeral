namespace GerenciadorGeral.domain.Entidades
{
  public class CustoProducao : EntidadeBase
  {
    public Guid IdSKU { get; set; }
    public DateTime DataCalculo { get; set; }
    public Guid IdUsuario { get; set; }    
    public virtual ICollection<CustoProducaoDetalhe> ListaProducaoDetalhe { get; set; }
    public string? Observacao { get; set; }
    public virtual Usuario? Usuario {get;set;}
    public virtual SKU? SKU { get; set; }

  }
}
