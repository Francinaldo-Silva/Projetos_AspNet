using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comum.Entity
{
    public abstract class EntityAbstractConfig<TEntidade> : EntityTypeConfiguration<TEntidade>
        where TEntidade : class

    {
        public EntityAbstractConfig()
        {
            ConfigurarNomeTabela();
            ConfiguararCamposTabela();
            ConfigurarChavePrimaria();
            ConfigurarChaveestrangeira();
        }

        protected abstract void ConfigurarChaveestrangeira();

        protected abstract void ConfigurarChavePrimaria();


        protected abstract void ConfiguararCamposTabela();


        protected abstract void ConfigurarNomeTabela();
      
    }
}
