using CTS.Musicas.AcessoDados.Entity.Context;
using CTS.Musicas.Dominio;
using CTS.Repositorios.Comum.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CTS.Musicas.Repositorios.Entity
{
    public class MusicasRepositorio : RepositorioGenericoEntity<Musica, long>
    {
        public MusicasRepositorio(MusicasDbContext contexto)
            : base(contexto)
        {

        }

        public override List<Musica> Selecionar()
        {
            //Sobrescreve o metodo da classe mãe
            return _contexto.Set<Musica>()
                .Include(p => p.Album).ToList();
        }

        public override Musica SelecionarPorId(long id)
        {
            //Sobrescreve o metodo da classe mãe
            return _contexto.Set<Musica>()
                .Include(p => p.Album)
                .SingleOrDefault(m => m.Id == id);
        }
    }
}
