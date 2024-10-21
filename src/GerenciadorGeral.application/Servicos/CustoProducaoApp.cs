using AutoMapper;
using GerenciadorGeral.application.DTO;
using GerenciadorGeral.application.Interfaces;
using GerenciadorGeral.domain.Interfaces.Servicos;
using System.Collections.Generic;

namespace GerenciadorGeral.application.Servicos
{
  public class CustoProducaoApp : ICustoProducaoApp
  {
    protected readonly ICompraItemServico _servicoCompraItem;    
    protected readonly IMapper _iMapper;
    public CustoProducaoApp(IMapper iMapper, ICompraItemServico servicoCompraItem) 
    {
      this._iMapper = iMapper;
      this._servicoCompraItem = servicoCompraItem;
    }

    public async Task<ICollection<CustoProducaoDTO>> ConsultaCustoPadrao()
    {
      //Qually
      var ultimaMargarinaComprada = await _servicoCompraItem.ConsultarUltimaCompra("MAR-500G-QUA");
      //Farinha de Trigo
      var ultimaFarinhaTrigoComprada = await _servicoCompraItem.ConsultarUltimaCompra("MAR-500G-QUA");
      //Açucar
      var ultimoAcucarComprado = await _servicoCompraItem.ConsultarUltimaCompra("MAR-500G-QUA");
      //Amido
      var ultimoAmidoComprado = await _servicoCompraItem.ConsultarUltimaCompra("MAR-500G-QUA");
      //Cremogema
      var ultimoCremogemaComprado = await _servicoCompraItem.ConsultarUltimaCompra("MAR-500G-QUA");
      //Sal
      var ultimoSalComprado = await _servicoCompraItem.ConsultarUltimaCompra("MAR-500G-QUA");

      ICollection<CustoProducaoDTO> lista = new HashSet<CustoProducaoDTO>();

      lista.Add(PopularItemCustoProducao(0.3M, _iMapper.Map<CompraItemDTO>(ultimaMargarinaComprada)));
      lista.Add(PopularItemCustoProducao(0.235M, _iMapper.Map<CompraItemDTO>(ultimaFarinhaTrigoComprada)));
      lista.Add(PopularItemCustoProducao(0.160M, _iMapper.Map<CompraItemDTO>(ultimoAcucarComprado)));
      lista.Add(PopularItemCustoProducao(0.240M, _iMapper.Map<CompraItemDTO>(ultimoAmidoComprado)));
      lista.Add(PopularItemCustoProducao(0.04M, _iMapper.Map<CompraItemDTO>(ultimoCremogemaComprado)));
      lista.Add(PopularItemCustoProducao(0.001M, _iMapper.Map<CompraItemDTO>(ultimoSalComprado)));

      foreach (var item in lista)
      {
        item.valorCustoProducao = ((item.valorCompra * item.qtd) / item.skuDTO.Quantidade);
      }

      return lista;
    }

    private CustoProducaoDTO PopularItemCustoProducao(decimal qtd, CompraItemDTO compraItem)
    {
      return new CustoProducaoDTO()
      {
        Id = Guid.NewGuid(),
        qtd = qtd,
        skuDTO = compraItem.SKU,
        valorCompra = compraItem.ValorUnitario
      };

    }

    public async Task<ICollection<CustoProducaoDTO>> Listar()
    { 
      ICollection<CustoProducaoDTO> lista = new HashSet<CustoProducaoDTO>();
      lista.Add(new CustoProducaoDTO()
      {
        Id = Guid.NewGuid(),
        qtd = 0.3M,
        skuDTO = new SKUDTO()
        {
          Nome = "Qually",
          Quantidade = 0.5M
        },
        valorCompra = 6M
      });
      lista.Add(new CustoProducaoDTO()
      {
        Id = Guid.NewGuid(),
        qtd = 0.235M,
        skuDTO = new SKUDTO()
        {
          Nome = "Farinha de Trigo"
        },
        valorCompra = 3.5M
      });
      lista.Add(new CustoProducaoDTO()
      {
        Id = Guid.NewGuid(),
        qtd = 0.160M,
        skuDTO = new SKUDTO()
        {
          Nome = "Açucar"
        },
        valorCompra = 4M
      });
      lista.Add(new CustoProducaoDTO()
      {
        Id = Guid.NewGuid(),
        qtd = 0.240M,
        skuDTO = new SKUDTO()
        {
          Nome = "Amido de milho"
        },
        valorCompra = 6.6M
      });
      lista.Add(new CustoProducaoDTO()
      {
        Id = Guid.NewGuid(),
        qtd = 0.040M,
        skuDTO = new SKUDTO()
        {
          Nome = "Cremogema"
        },
        valorCompra = 10M
      });
      lista.Add(new CustoProducaoDTO()
      {
        Id = Guid.NewGuid(),
        qtd = 0.001M,
        skuDTO = new SKUDTO()
        {
          Nome = "Sal"
        },
        valorCompra = 2.2M
      });

      return await TratarCusto(lista);

    }

    private async Task<ICollection<CustoProducaoDTO>> TratarCusto(ICollection<CustoProducaoDTO> listaCusto)
    {
      ICollection<CustoProducaoDTO> listaTratada = new HashSet<CustoProducaoDTO>();
      foreach (var item in listaCusto)
      {
        item.valorCustoProducao = ((item.valorCompra * item.qtd) / item.skuDTO.Quantidade);
        listaTratada.Add(item);
      }

      return listaTratada;
    }
  }
}
