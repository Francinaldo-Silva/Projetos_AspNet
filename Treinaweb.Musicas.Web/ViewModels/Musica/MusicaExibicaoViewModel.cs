﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Treinaweb.Musicas.Web.ViewModels.Musica
{
    public class MusicaExibicaoViewModel
    {
        public int Id { get; set; }
        [Display(Name ="Nome da música")]
        public string Nome { get; set; }
        [Display(Name = "Nome do album")]
        public string NomeAlbum { get; set; }
    }
}