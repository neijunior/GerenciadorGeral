namespace GerenciadorGeral.domain.Entidades
{
  public class Insumo : EntidadeBase
  {
    public string Nome { get; set; }    
    public virtual ICollection<SKU> ListaSKU { get; set; }
  }
}
