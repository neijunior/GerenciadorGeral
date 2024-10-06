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
    [Migration("20241005181245_Teste")]
    partial class Teste
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

                    b.Property<string>("RazaoSocial")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.HasKey("Id");

                    b.ToTable("Fornecedor", "dbo");
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

                    b.Property<Guid>("IdMarca")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar")
                        .HasColumnName("Nome");

                    b.Property<decimal>("Quantidade")
                        .HasColumnType("decimal(16,2)");

                    b.HasKey("Id");

                    b.HasIndex("CodigoUnidadeMedida");

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

            modelBuilder.Entity("GerenciadorGeral.domain.Entidades.SKU", b =>
                {
                    b.HasOne("GerenciadorGeral.domain.Entidades.UnidadeMedida", "UnidadeMedida")
                        .WithMany("SKUs")
                        .HasForeignKey("CodigoUnidadeMedida")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GerenciadorGeral.domain.Entidades.Marca", "Marca")
                        .WithMany("SKUs")
                        .HasForeignKey("IdMarca")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Marca");

                    b.Navigation("UnidadeMedida");
                });

            modelBuilder.Entity("GerenciadorGeral.domain.Entidades.Marca", b =>
                {
                    b.Navigation("SKUs");
                });

            modelBuilder.Entity("GerenciadorGeral.domain.Entidades.UnidadeMedida", b =>
                {
                    b.Navigation("SKUs");
                });
#pragma warning restore 612, 618
        }
    }
}
