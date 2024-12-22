﻿// <auto-generated />
using System;
using GerenciadorGeral.infra.Data.Contextos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GerenciadorGeral.infra.Data.Migrations
{
    [DbContext(typeof(Contexto))]
    partial class ContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("dbo")
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("GerenciadorGeral.domain.Entidades.Compra", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("Id");

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Desconto")
                        .HasColumnType("decimal(16,2)");

                    b.Property<Guid>("IdFornecedor")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Observacao")
                        .HasColumnType("varchar(200)");

                    b.Property<decimal>("ValorTotal")
                        .HasColumnType("decimal(16,2)");

                    b.HasKey("Id");

                    b.HasIndex("IdFornecedor");

                    b.ToTable("Compra", "dbo");
                });

            modelBuilder.Entity("GerenciadorGeral.domain.Entidades.CompraItem", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("Id");

                    b.Property<decimal>("Desconto")
                        .HasColumnType("decimal(16,2)");

                    b.Property<Guid>("IdCompra")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdSku")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Quantidade")
                        .HasColumnType("decimal(16,2)");

                    b.Property<decimal>("ValorTotal")
                        .HasColumnType("decimal(16,2)");

                    b.Property<decimal>("ValorUnitario")
                        .HasColumnType("decimal(16,2)");

                    b.HasKey("Id");

                    b.HasIndex("IdCompra");

                    b.HasIndex("IdSku");

                    b.ToTable("CompraItem", "dbo");
                });

            modelBuilder.Entity("GerenciadorGeral.domain.Entidades.CustoProducao", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("Id");

                    b.Property<DateTime>("DataCalculo")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("IdSKU")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdUsuario")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Observacao")
                        .HasColumnType("varchar(200)");

                    b.HasKey("Id");

                    b.HasIndex("IdSKU");

                    b.HasIndex("IdUsuario");

                    b.ToTable("CustoProducao", "dbo");
                });

            modelBuilder.Entity("GerenciadorGeral.domain.Entidades.CustoProducaoDetalhe", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("Id");

                    b.Property<decimal>("CustoAquisicaoItem")
                        .HasColumnType("decimal(16,2)");

                    b.Property<Guid>("IdCustoProducao")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdInsumo")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdSKU")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("QuantidadeUtilizada")
                        .HasColumnType("decimal(8,4)");

                    b.Property<decimal>("ValorCustoProducao")
                        .HasColumnType("decimal(16,2)");

                    b.HasKey("Id");

                    b.HasIndex("IdCustoProducao");

                    b.HasIndex("IdInsumo");

                    b.HasIndex("IdSKU");

                    b.ToTable("CustoProducaoDetalhe", "dbo");
                });

            modelBuilder.Entity("GerenciadorGeral.domain.Entidades.Fornecedor", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("Id");

                    b.Property<string>("CpfCnpj")
                        .IsRequired()
                        .HasMaxLength(14)
                        .HasColumnType("varchar")
                        .HasColumnName("CpfCnpj");

                    b.Property<Guid?>("IdEndereco")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("NomeFantasia")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<string>("RazaoSocial")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.HasKey("Id");

                    b.ToTable("Fornecedor", "dbo");
                });

            modelBuilder.Entity("GerenciadorGeral.domain.Entidades.Insumo", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("Id");

                    b.Property<string>("CodigoUnidadeMedida")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("varchar")
                        .HasColumnName("CodigoUnidadeMedida");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<bool>("ProducaoPropria")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("CodigoUnidadeMedida");

                    b.ToTable("Insumo", "dbo");
                });

            modelBuilder.Entity("GerenciadorGeral.domain.Entidades.Marca", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.HasKey("Id");

                    b.ToTable("Marca", "dbo");
                });

            modelBuilder.Entity("GerenciadorGeral.domain.Entidades.Menu", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("Id");

                    b.Property<Guid?>("IdPai")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Nivel")
                        .HasColumnType("int");

                    b.Property<int>("Ordem")
                        .HasColumnType("int");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasMaxLength(75)
                        .HasColumnType("varchar")
                        .HasColumnName("Titulo");

                    b.Property<string>("Url")
                        .HasColumnType("varchar(200)");

                    b.Property<string>("styleCss")
                        .HasColumnType("varchar(200)");

                    b.HasKey("Id");

                    b.ToTable("Menu", "dbo");
                });

            modelBuilder.Entity("GerenciadorGeral.domain.Entidades.SKU", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("Id");

                    b.Property<string>("Codigo")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<string>("CodigoUnidadeMedida")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("varchar")
                        .HasColumnName("CodigoUnidadeMedida");

                    b.Property<Guid?>("IdInsumo")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdMarca")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool?>("Interno")
                        .HasColumnType("bit");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar")
                        .HasColumnName("Nome");

                    b.Property<decimal>("Quantidade")
                        .HasColumnType("decimal(16,2)");

                    b.HasKey("Id");

                    b.HasIndex("CodigoUnidadeMedida");

                    b.HasIndex("IdInsumo");

                    b.HasIndex("IdMarca");

                    b.ToTable("SKU", "dbo");
                });

            modelBuilder.Entity("GerenciadorGeral.domain.Entidades.UnidadeMedida", b =>
                {
                    b.Property<string>("Codigo")
                        .HasMaxLength(5)
                        .HasColumnType("varchar")
                        .HasColumnName("Codigo");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar")
                        .HasColumnName("Descricao");

                    b.HasKey("Codigo");

                    b.ToTable("UnidadeMedida", "dbo");

                    b.HasData(
                        new
                        {
                            Codigo = "KG",
                            Descricao = "Quilograma"
                        },
                        new
                        {
                            Codigo = "G",
                            Descricao = "Grama"
                        },
                        new
                        {
                            Codigo = "UN",
                            Descricao = "Unidade"
                        },
                        new
                        {
                            Codigo = "L",
                            Descricao = "Litro"
                        },
                        new
                        {
                            Codigo = "ML",
                            Descricao = "Mililitro"
                        });
                });

            modelBuilder.Entity("GerenciadorGeral.domain.Entidades.Usuario", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.HasKey("Id");

                    b.ToTable("Usuario", "dbo");
                });

            modelBuilder.Entity("GerenciadorGeral.domain.Entidades.Compra", b =>
                {
                    b.HasOne("GerenciadorGeral.domain.Entidades.Fornecedor", "Fornecedor")
                        .WithMany("Compras")
                        .HasForeignKey("IdFornecedor")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Fornecedor");
                });

            modelBuilder.Entity("GerenciadorGeral.domain.Entidades.CompraItem", b =>
                {
                    b.HasOne("GerenciadorGeral.domain.Entidades.Compra", "Compra")
                        .WithMany("ListaItens")
                        .HasForeignKey("IdCompra")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GerenciadorGeral.domain.Entidades.SKU", "SKU")
                        .WithMany("ListaItens")
                        .HasForeignKey("IdSku")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Compra");

                    b.Navigation("SKU");
                });

            modelBuilder.Entity("GerenciadorGeral.domain.Entidades.CustoProducao", b =>
                {
                    b.HasOne("GerenciadorGeral.domain.Entidades.SKU", "SKU")
                        .WithMany("ListaCustoProducao")
                        .HasForeignKey("IdSKU")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GerenciadorGeral.domain.Entidades.Usuario", "Usuario")
                        .WithMany("CustoProducao")
                        .HasForeignKey("IdUsuario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SKU");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("GerenciadorGeral.domain.Entidades.CustoProducaoDetalhe", b =>
                {
                    b.HasOne("GerenciadorGeral.domain.Entidades.CustoProducao", "CustoProducao")
                        .WithMany("ListaProducaoDetalhe")
                        .HasForeignKey("IdCustoProducao")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GerenciadorGeral.domain.Entidades.Insumo", "Insumo")
                        .WithMany("ListaCustoProducaoDetalhe")
                        .HasForeignKey("IdInsumo")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("GerenciadorGeral.domain.Entidades.SKU", "SKU")
                        .WithMany("ListaCustoProducaoDetalhe")
                        .HasForeignKey("IdSKU")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("CustoProducao");

                    b.Navigation("Insumo");

                    b.Navigation("SKU");
                });

            modelBuilder.Entity("GerenciadorGeral.domain.Entidades.Insumo", b =>
                {
                    b.HasOne("GerenciadorGeral.domain.Entidades.UnidadeMedida", "UnidadeMedida")
                        .WithMany("Insumos")
                        .HasForeignKey("CodigoUnidadeMedida")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UnidadeMedida");
                });

            modelBuilder.Entity("GerenciadorGeral.domain.Entidades.SKU", b =>
                {
                    b.HasOne("GerenciadorGeral.domain.Entidades.UnidadeMedida", "UnidadeMedida")
                        .WithMany("SKUs")
                        .HasForeignKey("CodigoUnidadeMedida")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GerenciadorGeral.domain.Entidades.Insumo", "Insumo")
                        .WithMany("ListaSKU")
                        .HasForeignKey("IdInsumo");

                    b.HasOne("GerenciadorGeral.domain.Entidades.Marca", "Marca")
                        .WithMany("SKUs")
                        .HasForeignKey("IdMarca")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Insumo");

                    b.Navigation("Marca");

                    b.Navigation("UnidadeMedida");
                });

            modelBuilder.Entity("GerenciadorGeral.domain.Entidades.Compra", b =>
                {
                    b.Navigation("ListaItens");
                });

            modelBuilder.Entity("GerenciadorGeral.domain.Entidades.CustoProducao", b =>
                {
                    b.Navigation("ListaProducaoDetalhe");
                });

            modelBuilder.Entity("GerenciadorGeral.domain.Entidades.Fornecedor", b =>
                {
                    b.Navigation("Compras");
                });

            modelBuilder.Entity("GerenciadorGeral.domain.Entidades.Insumo", b =>
                {
                    b.Navigation("ListaCustoProducaoDetalhe");

                    b.Navigation("ListaSKU");
                });

            modelBuilder.Entity("GerenciadorGeral.domain.Entidades.Marca", b =>
                {
                    b.Navigation("SKUs");
                });

            modelBuilder.Entity("GerenciadorGeral.domain.Entidades.SKU", b =>
                {
                    b.Navigation("ListaCustoProducao");

                    b.Navigation("ListaCustoProducaoDetalhe");

                    b.Navigation("ListaItens");
                });

            modelBuilder.Entity("GerenciadorGeral.domain.Entidades.UnidadeMedida", b =>
                {
                    b.Navigation("Insumos");

                    b.Navigation("SKUs");
                });

            modelBuilder.Entity("GerenciadorGeral.domain.Entidades.Usuario", b =>
                {
                    b.Navigation("CustoProducao");
                });
#pragma warning restore 612, 618
        }
    }
}
