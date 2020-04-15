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
    public class DominioViewModel : Profile
    {
        protected override void Configure()
        {
            Mapper.CreateMap<Album, AlbumExibicaoViewModel>();
            Mapper.CreateMap<Album, AlbumViewModel>();
            Mapper.CreateMap<Musica, MusicaExibicaoViewModel>()
                .ForMember(p => p.NomeAlbum, opt => opt.MapFrom(src => src.album.Nome));
            Mapper.CreateMap<Musica, MusicaViewmodel>();
        }
    }
}