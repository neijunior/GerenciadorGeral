using AutoMapper;
using GerenciadorGeral.application.DTO;
using GerenciadorGeral.application.Interfaces;
using GerenciadorGeral.domain.Entidades;
using GerenciadorGeral.domain.Interfaces.Servicos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GerenciadorGeral.application.Servicos
{
  public class MarcaApp : IMarcaApp
  {
    public readonly IMarcaServico _servico;
    public readonly IMapper _iMapper;

    public MarcaApp(IMapper iMapper, IMarcaServico servico) : base()
    {
      this._iMapper = iMapper;
      this._servico = servico;
    }

    public async Task<Marca> Consultar(Guid Id)
    {
      return await _servico.Consultar<Marca>(w => w.Id == Id);
    }

    public async Task<RetornoDTO> Editar(Marca marca)
    {
      RetornoDTO retorno = new RetornoDTO()
      {
        Mensagem = "Sucesso",
        Sucesso = true
      };

      try
      {
        await _servico.Update(marca);
      }
      catch (Exception ex)
      {
        retorno.Sucesso = false;
        retorno.Mensagem = ex.Message;        
      }


      return retorno;
    }

    public async Task<RetornoDTO> Excluir(Guid Id)
    {
      RetornoDTO retorno = new RetornoDTO()
      {
        Mensagem = "Sucesso",
        Sucesso = true
      };

      try
      {
        await _servico.Delete(Id);
      }
      catch (Exception ex)
      {
        retorno.Sucesso = false;
        retorno.Mensagem = ex.Message;
      }


      return retorno;
    }

    public async Task<ICollection<Marca>> Listar()
    {
      return await _servico.Listar<Marca>();
    }

    public async Task<RetornoDTO> Salvar(Marca marca)
    {
      RetornoDTO retorno = new RetornoDTO()
      {
        Mensagem = "Sucesso",
        Sucesso = true
      };

      try
      {
        await _servico.Insert(marca);
      }
      catch (Exception ex)
      {
        retorno.Sucesso = false;
        retorno.Mensagem = ex.Message;
      }


      return retorno;
    }
  }
}
