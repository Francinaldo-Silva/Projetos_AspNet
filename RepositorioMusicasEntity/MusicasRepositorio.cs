using RepositorioComumEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Treinaweb.Musicas.Acesso.Entity.Context;
using Treinaweb.Musicas.Dominio;
using System.Data.Entity;

namespace RepositorioMusicasEntity
{
    public class MusicasRepositorio : RepositorioGenericoEntity<Musica, long>
    {
        public MusicasRepositorio(MusicasDbContext contexto)
            : base(contexto)
        {

        }
        public override List<Musica> Selecionar()
        {
            return _contexto.Set<Musica>().Include(p => p.album).ToList();
        }
        public override Musica SelecionarId(long Id)
        {
            return _contexto.Set<Musica>().Include(p => p.album).SingleOrDefault(m => m.Id == Id);
        }
    }
}
