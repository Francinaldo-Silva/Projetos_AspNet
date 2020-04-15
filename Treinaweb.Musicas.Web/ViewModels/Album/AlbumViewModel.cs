using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Treinaweb.Musicas.Web.ViewModels.Album
{
    public class AlbumViewModel
    {
        [Required(ErrorMessage ="ID obrigatório")]
        public int Id { get; set; }

        [Display(Name = "Nome do álbum")]
        [Required(ErrorMessage ="O nome do album é obrigatorio")]
        [MaxLength(100, ErrorMessage ="O nome só pode ter 100 caracteres")]
        public string Nome { get; set; }
        [Display(Name = "Ano do álbum")]
        [Required(ErrorMessage = "O ano do album é obrigatorio")]
        public int Ano { get; set; }
        [Display(Name = "Observações do álbum")]
        [MaxLength(1000, ErrorMessage ="Só devem ter 1000(mil) caracteres")]
        public string Observacoes { get; set; }
    }
}