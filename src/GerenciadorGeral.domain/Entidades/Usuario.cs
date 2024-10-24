namespace GerenciadorGeral.domain.Entidades
{
  public class Usuario : EntidadeBase
  {
    public string Nome { get; set; }  
    public string Email { get; set; }
    public virtual ICollection<CustoProducao> CustoProducao { get; set; }
  }
}
