﻿// <auto-generated />
using System;
using LocadoraAutomoveis.Infraestrutura.Compartilhado;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LocadoraAutomoveis.Infraestrutura.Migrations
{
    [DbContext(typeof(ContextoDados))]
    partial class ContextoDadosModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AluguelTaxaEServico", b =>
                {
                    b.Property<Guid>("AluguelID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ListaTaxasEServicosID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("AluguelID", "ListaTaxasEServicosID");

                    b.HasIndex("ListaTaxasEServicosID");

                    b.ToTable("FK_TBAluguel_TBTaxaEServico", (string)null);
                });

            modelBuilder.Entity("LocadoraAutomoveis.Dominio.ModuloAluguel.Aluguel", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AutomovelID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CategoriaAutomoveisID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ClienteID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("CombustivelRestante")
                        .HasColumnType("int");

                    b.Property<bool>("Concluido")
                        .HasColumnType("bit");

                    b.Property<Guid>("CondutorID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CupomID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DataDevolucao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataLocacao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataPrevistaRetorno")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("FuncionarioID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Plano")
                        .HasColumnType("int");

                    b.Property<Guid>("PlanoCobrancaID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal?>("QuilometrosRodados")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("ValorTotal")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ID");

                    b.HasIndex("AutomovelID");

                    b.HasIndex("CategoriaAutomoveisID");

                    b.HasIndex("ClienteID");

                    b.HasIndex("CondutorID");

                    b.HasIndex("CupomID");

                    b.HasIndex("FuncionarioID");

                    b.HasIndex("PlanoCobrancaID");

                    b.ToTable("TBAluguel", (string)null);
                });

            modelBuilder.Entity("LocadoraAutomoveis.Dominio.ModuloAutomovel.Automovel", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Alugado")
                        .HasColumnType("bit");

                    b.Property<int>("Ano")
                        .HasColumnType("int");

                    b.Property<decimal>("CapacidadeCombustivel")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid>("CategoriaID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Cor")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<byte[]>("Imagem")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Marca")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Modelo")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Placa")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<decimal>("Quilometragem")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("TipoCombustivel")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("CategoriaID");

                    b.ToTable("TBAutomovel", (string)null);
                });

            modelBuilder.Entity("LocadoraAutomoveis.Dominio.ModuloCategoriaAutomoveis.CategoriaAutomoveis", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.HasKey("ID");

                    b.ToTable("TBCategoriaAutomoveis", (string)null);
                });

            modelBuilder.Entity("LocadoraAutomoveis.Dominio.ModuloCliente.Cliente", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasColumnType("varchar(120)");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasColumnType("varchar(60)");

                    b.Property<string>("Documento")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<int>("Numero")
                        .HasColumnType("int");

                    b.Property<string>("Rua")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<int>("TipoCliente")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("TBCliente", (string)null);
                });

            modelBuilder.Entity("LocadoraAutomoveis.Dominio.ModuloCondutores.Condutor", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CNH")
                        .IsRequired()
                        .HasColumnType("varchar(30)");

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<Guid>("ClienteID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<bool>("TipoCondutor")
                        .HasColumnType("bit");

                    b.Property<DateTime>("Validade")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.HasIndex("ClienteID");

                    b.ToTable("TBCondutor", (string)null);
                });

            modelBuilder.Entity("LocadoraAutomoveis.Dominio.ModuloCupom.Cupom", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DataValidade")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<Guid>("ParceiroID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("QtdUsos")
                        .HasColumnType("int");

                    b.Property<decimal>("Valor")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ID");

                    b.HasIndex("ParceiroID");

                    b.ToTable("TBCupom", (string)null);
                });

            modelBuilder.Entity("LocadoraAutomoveis.Dominio.ModuloFuncionario.Funcionario", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Admissao")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<decimal>("Salario")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ID");

                    b.ToTable("TBFuncionario", (string)null);
                });

            modelBuilder.Entity("LocadoraAutomoveis.Dominio.ModuloParceiro.Parceiro", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.HasKey("ID");

                    b.ToTable("TBParceiro", (string)null);
                });

            modelBuilder.Entity("LocadoraAutomoveis.Dominio.ModuloPlanosCobrancas.PlanoCobranca", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CategoriaAutomoveisID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("PlanoControlador_LimiteKm")
                        .HasColumnType("int");

                    b.Property<decimal>("PlanoControlador_ValorDiario")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("PlanoControlador_ValorKm")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("PlanoDiario_ValorDiario")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("PlanoDiario_ValorKm")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("PlanoLivre_ValorDiario")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ID");

                    b.HasIndex("CategoriaAutomoveisID");

                    b.ToTable("TBPlanoCobranca", (string)null);
                });

            modelBuilder.Entity("LocadoraAutomoveis.Dominio.ModuloTaxaEServico.TaxaEServico", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<int>("Tipo")
                        .HasColumnType("int");

                    b.Property<decimal>("Valor")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ID");

                    b.ToTable("TBTaxaEServico", (string)null);
                });

            modelBuilder.Entity("AluguelTaxaEServico", b =>
                {
                    b.HasOne("LocadoraAutomoveis.Dominio.ModuloAluguel.Aluguel", null)
                        .WithMany()
                        .HasForeignKey("AluguelID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LocadoraAutomoveis.Dominio.ModuloTaxaEServico.TaxaEServico", null)
                        .WithMany()
                        .HasForeignKey("ListaTaxasEServicosID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("LocadoraAutomoveis.Dominio.ModuloAluguel.Aluguel", b =>
                {
                    b.HasOne("LocadoraAutomoveis.Dominio.ModuloAutomovel.Automovel", "Automovel")
                        .WithMany()
                        .HasForeignKey("AutomovelID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired()
                        .HasConstraintName("FK_TBAluguel_TBAutomovel");

                    b.HasOne("LocadoraAutomoveis.Dominio.ModuloCategoriaAutomoveis.CategoriaAutomoveis", "CategoriaAutomoveis")
                        .WithMany()
                        .HasForeignKey("CategoriaAutomoveisID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired()
                        .HasConstraintName("FK_TBAluguel_TBCategoriaAutomoveis");

                    b.HasOne("LocadoraAutomoveis.Dominio.ModuloCliente.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired()
                        .HasConstraintName("FK_TBAluguel_TBCliente");

                    b.HasOne("LocadoraAutomoveis.Dominio.ModuloCondutores.Condutor", "Condutor")
                        .WithMany()
                        .HasForeignKey("CondutorID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired()
                        .HasConstraintName("FK_TBAluguel_TBCondutor");

                    b.HasOne("LocadoraAutomoveis.Dominio.ModuloCupom.Cupom", "Cupom")
                        .WithMany()
                        .HasForeignKey("CupomID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .HasConstraintName("FK_TBAluguel_TBCupom");

                    b.HasOne("LocadoraAutomoveis.Dominio.ModuloFuncionario.Funcionario", "Funcionario")
                        .WithMany()
                        .HasForeignKey("FuncionarioID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired()
                        .HasConstraintName("FK_TBAluguel_TBFuncionario");

                    b.HasOne("LocadoraAutomoveis.Dominio.ModuloPlanosCobrancas.PlanoCobranca", "PlanoCobranca")
                        .WithMany()
                        .HasForeignKey("PlanoCobrancaID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired()
                        .HasConstraintName("FK_TBAluguel_TBPlanoCobranca");

                    b.Navigation("Automovel");

                    b.Navigation("CategoriaAutomoveis");

                    b.Navigation("Cliente");

                    b.Navigation("Condutor");

                    b.Navigation("Cupom");

                    b.Navigation("Funcionario");

                    b.Navigation("PlanoCobranca");
                });

            modelBuilder.Entity("LocadoraAutomoveis.Dominio.ModuloAutomovel.Automovel", b =>
                {
                    b.HasOne("LocadoraAutomoveis.Dominio.ModuloCategoriaAutomoveis.CategoriaAutomoveis", "Categoria")
                        .WithMany()
                        .HasForeignKey("CategoriaID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired()
                        .HasConstraintName("FK_TBAutomovel_TBCategoriaAutomoveis");

                    b.Navigation("Categoria");
                });

            modelBuilder.Entity("LocadoraAutomoveis.Dominio.ModuloCondutores.Condutor", b =>
                {
                    b.HasOne("LocadoraAutomoveis.Dominio.ModuloCliente.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired()
                        .HasConstraintName("FK_TBCondutor_TBCliente");

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("LocadoraAutomoveis.Dominio.ModuloCupom.Cupom", b =>
                {
                    b.HasOne("LocadoraAutomoveis.Dominio.ModuloParceiro.Parceiro", "Parceiro")
                        .WithMany()
                        .HasForeignKey("ParceiroID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired()
                        .HasConstraintName("FK_TBCupom_TBParceiro");

                    b.Navigation("Parceiro");
                });

            modelBuilder.Entity("LocadoraAutomoveis.Dominio.ModuloPlanosCobrancas.PlanoCobranca", b =>
                {
                    b.HasOne("LocadoraAutomoveis.Dominio.ModuloCategoriaAutomoveis.CategoriaAutomoveis", "CategoriaAutomoveis")
                        .WithMany()
                        .HasForeignKey("CategoriaAutomoveisID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired()
                        .HasConstraintName("FK_TBPlanoCobranca_TBCategoriaAutomoveis");

                    b.Navigation("CategoriaAutomoveis");
                });
#pragma warning restore 612, 618
        }
    }
}
