using System.ComponentModel.DataAnnotations;

namespace GerenciadorGeral.application.DTO
{
  public class SKUDTO : BaseDTO
  {
    public string Codigo { get; set; }
    [Required(ErrorMessage = "O SKU é obrigatório")]
    public string Nome { get; set; }
    [Required(ErrorMessage = "A Unidade de Medida é obrigatória")]
    public string CodigoUnidadeMedida { get; set; }
    public decimal Quantidade { get; set; }
    public Guid IdMarca { get; set; }
    public string NomeMarca { get; set; }
    public bool Interno { get; set; }
  }
}
