using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Treinaweb.Musicas.Web.ViewModels.Musica
{
    public class MusicaViewmodel
    {
        [Required(ErrorMessage ="id obrigatorio")]
        public int Id { get; set; }
        [Required(ErrorMessage = "Nome obrigatorio")]
        [MaxLength(50,ErrorMessage ="maximo 50 caracteres")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "selecione um Album")]
        public int IdAlbum { get; set; }
    }
}