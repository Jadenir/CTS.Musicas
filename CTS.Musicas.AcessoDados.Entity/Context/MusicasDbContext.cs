using CTS.Musicas.AcessoDados.Entity.TypeConfiguration;
using CTS.Musicas.Dominio;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTS.Musicas.AcessoDados.Entity.Context
{
    public class MusicasDbContext : DbContext
    {
        public DbSet<Album> Albuns { get; set; }

        public MusicasDbContext()
        {
            //Desabilida o carregamento lento, trabalhando com carregamento rápido
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
        }

        //Configura para usar as configurações de tabela criados ao inves do padrão do Entity
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AlbumTypeConfiguration());
        }
    }
}
