﻿using LocadoraAutomoveis.Dominio.ModuloPlanosCobrancas;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LocadoraAutomoveis.Infraestrutura.Mapeadores
{
    public class MapeadorPlanosCobrancas : IEntityTypeConfiguration<PlanoCobranca>
    {
        public void Configure(EntityTypeBuilder<PlanoCobranca> builder)
        {
            builder.ToTable("TBPlanoCobranca");
            builder.HasKey(p => p.ID);
            builder.Property(p => p.ValorDia).IsRequired();
            builder.Property(p => p.ValorKmRodado).IsRequired();
            builder.Property(p => p.KmLivre).IsRequired();
            builder.Property(p => p.Plano).IsRequired();

            builder.HasOne(p => p.CategoriaAutomoveis)
                .WithMany()
                .IsRequired()
                .HasConstraintName("FK_TBPlanoCobranca_TBCategoriaAutomoveis")
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
