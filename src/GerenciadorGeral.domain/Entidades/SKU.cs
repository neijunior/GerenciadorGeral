namespace GerenciadorGeral.domain.Entidades
{
  public class SKU : EntidadeBase
  {
    public string Codigo { get; set; }
    public string Nome { get; set; }
    public string CodigoUnidadeMedida { get; set; }
    public decimal Quantidade { get; set; }
    public Guid IdMarca { get; set; }
    //public virtual ICollection<CompraItem> ListaItens { get; set; }
    public virtual UnidadeMedida? UnidadeMedida { get; set; }
    public virtual Marca? Marca { get; set; }
    
  }
}
