using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorGeral.application.DTO
{
  public class CustoProducaoDTO : BaseDTO
  {
    
    public string NomeItemProduzido { get; set; }
    public DateTime DataCalculo { get; set; }
    public Guid IdUsuario { get; set; }
    public string Observacao { get; set; }
    public UsuarioDTO Usuario { get; set; }
    public ICollection<CustoProducaoDetalheDTO> ListaItens { get; set; }
  }
}
