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
    public class ViewModelParaDominioProfile : Profile
    {
        protected override void Configure()
        {
            Mapper.CreateMap<AlbumViewModel, Album>();
            Mapper.CreateMap<MusicaViewModel, Musica>();
        }
    }
}