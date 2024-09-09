using AutoMapper;
using GerenciadorGeral.application.DTO;
using GerenciadorGeral.application.Interfaces;
using GerenciadorGeral.domain.Entidades;
using GerenciadorGeral.domain.Interfaces.Servicos;
using System.Text;

namespace GerenciadorGeral.application.Servicos
{
  public class MenuApp : AppBase<Menu, MenuDTO>, IMenuApp
  {
    protected readonly IMenuServico _servico;
    protected readonly IMapper _iMapper;
    public MenuApp(IMapper iMapper, IMenuServico servico) : base(iMapper, servico)
    {
      this._servico = servico;
      this._iMapper = iMapper;
    }

    public async Task<ICollection<MenuDTO>> ListarFilhos(Guid IdPai)
    {
      var lista = base._iMapperBase.Map<ICollection<MenuDTO>>(await _servico.ListarFilhos(IdPai));
      return lista;
    }

    public async Task<ICollection<MenuDTO>> MontarMenu()
    {
      ICollection<MenuDTO> menuMontado = new HashSet<MenuDTO>();
      var listaNivelZero = await _servico.ListarNivelZero();
      foreach (var item in listaNivelZero)
      {
        menuMontado.Add(PopularMenuDTO(item));
        PopularMenuSubMenu(item.Id, await _servico.ListarFilhos(item.Id), ref menuMontado);
      }

      return menuMontado;
    }

    private void PopularMenuSubMenu(Guid id, ICollection<Menu> listaMenuBD, ref ICollection<MenuDTO> menuMontado)
    {
      IEnumerable<Menu> lista = listaMenuBD.Where(w => w.IdPai == id && w.IdPai != w.Id).OrderBy(o => o.Ordem);
      MenuDTO filho = menuMontado.FirstOrDefault(s => s.Id == id);
      if (filho == null)
      {
        filho = new MenuDTO();
      }

      filho.Filhos = filho.Filhos ?? new HashSet<MenuDTO>();

      foreach (Menu m in lista)
      {
        filho.Filhos.Add(PopularMenuDTO(m));
        var filhos = filho.Filhos;
        PopularMenuSubMenu(m.Id, lista.ToList(), ref filhos);
        filho.Filhos = filhos;
      }
    }

    private MenuDTO PopularMenuDTO(Menu menu)
    {
      return new MenuDTO()
      {
        Id = menu.Id,
        IdPai = menu.IdPai,
        Ordem = menu.Ordem,
        Titulo = menu.Titulo,
        Url = menu.Url,
        styleCss = menu.styleCss,
        Nivel = menu.Nivel
      };
    }
  }
}
