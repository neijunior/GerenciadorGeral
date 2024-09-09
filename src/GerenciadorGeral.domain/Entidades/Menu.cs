namespace GerenciadorGeral.domain.Entidades
{
  public class Menu : EntidadeBase
  {
    public Guid? IdPai { get; set; }
    public string? styleCss { get; set; }
    public string Titulo { get; set; }
    public string? Url { get; set; }    
    public int Nivel { get; set; }
    public int Ordem { get; set; }
  }
}
