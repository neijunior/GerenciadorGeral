using System.ComponentModel.DataAnnotations;

namespace GerenciadorGeral.application.DTO
{
  public class SKUDTO : BaseDTO
  {
    [Required(ErrorMessage = "O SKU é obrigatório")]
    public string Nome { get; set; }
    [Required(ErrorMessage = "A Unidade de Medida é obrigatória")]
    public decimal Quantidade { get; set; }
    public string Descricao { get; set; }
    public string UnidadeMedida { get; set; }
  }
}
