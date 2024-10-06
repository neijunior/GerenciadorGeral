namespace GerenciadorGeral.domain.Entidades
{
  public class SKU : EntidadeBase
  {
    public string Nome { get; set; }
    public string UnidadeMedida { get; set; }
    public string Quantidade { get; set; }
    public string Descricao { get; set; }
    public virtual ICollection<CompraItem> ListaItens { get; set; }
  }
}
