using AutoMapper;
using GerenciadorGeral.application.DTO;
using GerenciadorGeral.domain.Entidades;

namespace GerenciadorGeral.application
{
  public class MappingEntidade : Profile
  {
    public MappingEntidade()
    {
      CreateMap<SKU, SKUDTO>().ReverseMap();
      CreateMap<UnidadeMedida, UnidadeMedidaDTO>().ReverseMap();
      CreateMap<Compra, CompraDTO>().ReverseMap();
      CreateMap<CompraItem, CompraItemDTO>().ReverseMap();
      CreateMap<Fornecedor, FornecedorDTO>().ReverseMap();
      CreateMap<Menu, MenuDTO>().ReverseMap();
      CreateMap<Usuario, UsuarioDTO>().ReverseMap();
      CreateMap<CustoProducao, CustoProducaoDTO>().ReverseMap();
      CreateMap<CustoProducaoDetalhe, CustoProducaoDetalheDTO>().ReverseMap();
      CreateMap<Insumo, InsumoDTO>().ReverseMap();
    }
  }
}
