using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorGeral.domain.Entidades
{
  public class Fornecedor : EntidadeBase
  {    
    public string CpfCnpj { get; set; }
    public string Nome { get; set; }
    public Guid? IdEndereco { get; set; }
    public virtual ICollection<Compra> Compras { get; set; }
  }
}
