﻿// <auto-generated />
using System;
using GerenciadorGeral.infra.Data.Contextos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GerenciadorGeral.infra.Data.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20240830231027_AddTables_1")]
    partial class AddTables_1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid>("IdFornecedor")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Observacao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("ValorTotal")
                        .HasColumnType("decimal(18,2)");

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
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid>("IdCompra")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdSku")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Quantidade")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("QuantidadePorUnidadeMedida")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("QuantidadePorUnidadeMedidaTotal")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("UnidadeMedida")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("ValorTotal")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("ValorUnitario")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("IdCompra");

                    b.HasIndex("IdSku");

                    b.ToTable("CompraItem", "dbo");
                });

            modelBuilder.Entity("GerenciadorGeral.domain.Entidades.Fornecedor", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CpfCnpj")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("IdEndereco")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Fornecedor", "dbo");
                });

            modelBuilder.Entity("GerenciadorGeral.domain.Entidades.SKU", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("Id");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar")
                        .HasColumnName("Nome");

                    b.Property<string>("UnidadeMedida")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("varchar")
                        .HasColumnName("UnidadeMedida");

                    b.HasKey("Id");

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

            modelBuilder.Entity("GerenciadorGeral.domain.Entidades.Compra", b =>
                {
                    b.Navigation("ListaItens");
                });

            modelBuilder.Entity("GerenciadorGeral.domain.Entidades.Fornecedor", b =>
                {
                    b.Navigation("Compras");
                });

            modelBuilder.Entity("GerenciadorGeral.domain.Entidades.SKU", b =>
                {
                    b.Navigation("ListaItens");
                });
#pragma warning restore 612, 618
        }
    }
}
