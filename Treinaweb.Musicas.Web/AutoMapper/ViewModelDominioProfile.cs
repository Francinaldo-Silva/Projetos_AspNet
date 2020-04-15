using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Treinaweb.Musicas.Dominio;
using Treinaweb.Musicas.Web.ViewModels.Album;
using Treinaweb.Musicas.Web.ViewModels.Musica;

namespace Treinaweb.Musicas.Web.AutoMapper
{
    public class ViewModelDominioProfile : Profile
    {
        protected override void Configure()
        {
            Mapper.CreateMap<AlbumViewModel, Album>();
            Mapper.CreateMap<MusicaViewmodel, Musica>();
        }
    }
}