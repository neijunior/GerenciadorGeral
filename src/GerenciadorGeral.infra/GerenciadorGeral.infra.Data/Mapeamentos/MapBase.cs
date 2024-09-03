﻿using GerenciadorGeral.domain.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GerenciadorGeral.infra.Data.Mapeamentos
{
  public class MapBase<T> : IEntityTypeConfiguration<T> where T : EntidadeBase
  {
    public virtual void Configure(EntityTypeBuilder<T> builder)
    {
      builder.HasKey(c => c.Id);      
      builder.Property(c => c.Id).IsRequired().HasColumnName("Id");
    }
  }

}
