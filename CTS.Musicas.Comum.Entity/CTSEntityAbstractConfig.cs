using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTS.Musicas.Comum.Entity
{
    public abstract class CTSEntityAbstractConfig<TEntidade> : EntityTypeConfiguration<TEntidade>
        where TEntidade : class
    {
        public CTSEntityAbstractConfig()
        {
            ConfigurarNomeTabela();
            ConfigurarCamposTabela();
            ConfigurarChavesPrimarias();
            ConfigurarChavesEstrangeiras();
        }

        protected abstract void ConfigurarChavesEstrangeiras();
        protected abstract void ConfigurarChavesPrimarias();
        protected abstract void ConfigurarCamposTabela();
        protected abstract void ConfigurarNomeTabela();
    }
}
