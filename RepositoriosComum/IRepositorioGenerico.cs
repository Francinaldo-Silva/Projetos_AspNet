using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoriosComum
{
    public interface IRepositorioGenerico<TEntidade, TChave>
        where TEntidade : class
    {
        List<TEntidade> Selecionar();
        TEntidade SelecionarId(TChave Id);
        void Inserir(TEntidade entidade);
        void Alterar(TEntidade entidade);
        void Excluir(TEntidade entidade);
        void ExcluirId(TChave Id);
    }
}
