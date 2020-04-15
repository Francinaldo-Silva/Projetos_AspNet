using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Treinaweb.Musicas.Web.ViewModels.Album
{
    public class AlbumExibicaoViewModel
    {
        public int Id { get; set; }
        [Display(Name = "Nome do álbum")]
        public string Nome { get; set; }
        [Display(Name = "Ano do álbum")]
        public int Ano { get; set; }
        [Display(Name = "Observações do álbum")]
        public string Observacoes { get; set; }
    }
}