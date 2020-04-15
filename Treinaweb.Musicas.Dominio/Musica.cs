﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treinaweb.Musicas.Dominio
{
    public class Musica
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public virtual Album album { get; set; }
        public int IdAlbum { get; set; }
    }
}
