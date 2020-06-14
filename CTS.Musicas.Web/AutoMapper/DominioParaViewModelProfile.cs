using AutoMapper;
using CTS.Musicas.Dominio;
using CTS.Musicas.Web.ViewModels.Album;
using CTS.Musicas.Web.ViewModels.Musica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CTS.Musicas.Web.AutoMapper
{
    public class DominioParaViewModelProfile : Profile
    {
        protected override void Configure()
        {
            Mapper.CreateMap<Album, AlbumExibicaoViewModel>()
                .ForMember(p => p.Nome, opt =>
                {
                    opt.MapFrom(src =>
                    string.Format("{0} ({1})", src.Nome, src.Ano.ToString())
                        );
                });

            Mapper.CreateMap<Album, AlbumViewModel>();
            Mapper.CreateMap<Musica, MusicaExibicaoViewModel>()
                .ForMember(p => p.NomeAlbum, opt =>
                {
                    opt.MapFrom(src =>
                        src.Album.Nome
                    );
                });
            Mapper.CreateMap<Musica, MusicaViewModel>();
        }
    }
}