using AutoMapper;
using GerenciadorGeral.application.DTO;
using GerenciadorGeral.application.Interfaces;
using GerenciadorGeral.domain.Entidades;
using GerenciadorGeral.domain.Interfaces.Servicos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorGeral.application.Servicos
{
  public class DeParaInsumoSKUApp : AppBase<DeParaInsumoSKU, DeParaInsumoSKUDTO>, IDeParaInsumoSKUApp
  {
    public DeParaInsumoSKUApp(IMapper iMapper, IDeParaInsumoSKUServico servico) : base(iMapper, servico)
    {
    }
  }
}
