using GerenciadorGeral.domain.Entidades;

namespace GerenciadorGeral.application.DTO
{
  public class UsuarioDTO : BaseDTO
  {
    public string Nome { get; set; }
    public string Email { get; set; }
    public virtual ICollection<CustoProducao> CustoProducao { get; set; }
  }
}
