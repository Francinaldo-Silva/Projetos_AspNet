using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Treinaweb.Musicas.Acesso.Entity.TypeConfiguration;
using Treinaweb.Musicas.Dominio;

namespace Treinaweb.Musicas.Acesso.Entity.Context
{
    public class MusicasDbContext : DbContext
    {
        public DbSet<Album> Albuns { get; set; }
        public DbSet<Musica> Musicas { get; set; }
        public MusicasDbContext()
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AlbumTypeConfiguration());
            modelBuilder.Configurations.Add(new MusicaTypeConfiguration());

        }


    }
}
