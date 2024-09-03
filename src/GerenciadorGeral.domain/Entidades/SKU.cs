namespace GerenciadorGeral.domain.Entidades
{
  public class SKU : EntidadeBase
  {
    public string Nome { get; set; }
    public string UnidadeMedida { get; set; }
    public virtual ICollection<CompraItem> ListaItens { get; set; }
  }
}
