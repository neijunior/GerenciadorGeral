using System.ComponentModel.DataAnnotations;

namespace GerenciadorGeral.application.DTO
{
  public class MenuDTO : BaseDTO
  {
    public Guid? IdPai { get; set; }
    public string styleCss { get; set; }
    [Required(ErrorMessage = "O Título é obrigatório")]
    public string Titulo { get; set; }    
    public string Url { get; set; }
    public int Nivel { get; set; }
    public int Ordem { get; set; }
    public ICollection<MenuDTO> Filhos { get; set; }
  }
}
