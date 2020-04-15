using RepositorioComumEntity;
using RepositoriosComum;
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
    public class AlbunsRepositorio : RepositorioGenericoEntity<Album, int>
    {
        public AlbunsRepositorio(MusicasDbContext contexto)
            : base(contexto)
        {

        }
        public override List<Album> Selecionar()
        {
            return _contexto.Set<Album>().Include(p => p.Musicas).ToList();
        }
        public override Album SelecionarId(int Id)
        {
            return _contexto.Set<Album>().Include(p => p.Musicas).SingleOrDefault(a => a.Id == Id);
        }
    }
}
