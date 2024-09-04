using GerenciadorGeral.domain.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorGeral.infra.Data.Mapeamentos
{
    public class FornecedorMap : MapBase<Fornecedor>
    {
        public override void Configure(EntityTypeBuilder<Fornecedor> builder)
        {
            base.Configure(builder);
            builder.ToTable("Fornecedor", "dbo");
            builder.Property(c => c.CpfCnpj).IsRequired().HasColumnName("CpfCnpj").HasMaxLength(14).HasColumnType("varchar");            
        }
    }
}
