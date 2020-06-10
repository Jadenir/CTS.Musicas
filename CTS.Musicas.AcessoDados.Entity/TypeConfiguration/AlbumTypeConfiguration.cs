﻿using CTS.Musicas.Comum.Entity;
using CTS.Musicas.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTS.Musicas.AcessoDados.Entity.TypeConfiguration
{
    class AlbumTypeConfiguration : CTSEntityAbstractConfig<Album>
    {
        protected override void ConfigurarCamposTabela()
        {
            Property(p => p.Id)
                .IsRequired()
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)
                .HasColumnName("ALB_ID");
            
            Property(p => p.Nome)
                .IsRequired()
                .HasColumnName("ALB_NOME")
                .HasMaxLength(100);

            Property(p => p.Ano)
                .IsRequired()
                .HasColumnName("ALB_ANO");

            Property(p => p.Observacoes)
                .IsOptional()
                .HasColumnName("ALB_OBSERVACOES")
                .HasMaxLength(1000);
        }

        protected override void ConfigurarChavesEstrangeiras()
        {
            HasKey(pk => pk.Id);
        }

        protected override void ConfigurarChavesPrimarias()
        {

        }

        protected override void ConfigurarNomeTabela()
        {
            ToTable("ALB_ALBUNS");
        }
    }
}
