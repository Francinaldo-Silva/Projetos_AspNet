using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Treinaweb.Musicas.Web.AutoMapper;

namespace Treinaweb.Musicas.Web.App_Start
{
    public static class AutoMapperConfig
    {
        public static void Configurar()
        {
            Mapper.AddProfile<DominioViewModel>();
            Mapper.AddProfile<ViewModelDominioProfile>();
        }
    }
}