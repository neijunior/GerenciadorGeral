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
        }
    }
}
