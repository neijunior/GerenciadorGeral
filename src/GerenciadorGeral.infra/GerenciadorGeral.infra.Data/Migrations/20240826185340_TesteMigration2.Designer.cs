﻿// <auto-generated />
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
    [Migration("20240826185340_TesteMigration2")]
    partial class TesteMigration2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("GerenciadorGeral.domain.Entidades.SKU", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("Nome");

                    b.Property<string>("UnidadeMedida")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("UnidadeMedida");

                    b.HasKey("Id");

                    b.ToTable("Sku", "dbo");
                });
#pragma warning restore 612, 618
        }
    }
}
