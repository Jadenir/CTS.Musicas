﻿using CTS.Musicas.AcessoDados.Entity.Context;
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
    public class AlbunsRepositorio : RepositorioGenericoEntity<Album, int>
    {
        public AlbunsRepositorio(MusicasDbContext contexto)
            : base(contexto)
        {

        }

        public override List<Album> Selecionar()
        {
            //Sobrescreve o metodo da classe mãe
            return _contexto.Set<Album>()
                .Include(p => p.Musicas).ToList();
        }

        public override Album SelecionarPorId(int id)
        {
            //Sobrescreve o metodo da classe mãe
            return _contexto.Set<Album>()
                .Include(p => p.Musicas)
                .SingleOrDefault(a => a.Id == id);
        }
    }
}
