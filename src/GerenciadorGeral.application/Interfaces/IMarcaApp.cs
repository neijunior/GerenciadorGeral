using GerenciadorGeral.application.DTO;
using GerenciadorGeral.domain.Entidades;

namespace GerenciadorGeral.application.Interfaces
{
  public interface IMarcaApp 
  {
    Task<Marca> Consultar(Guid Id);
    Task<RetornoDTO> Salvar(Marca marca);
    Task<RetornoDTO> Editar(Marca marca);
    Task<RetornoDTO> Excluir(Guid Id);
    Task<ICollection<Marca>> Listar();
  }
}
