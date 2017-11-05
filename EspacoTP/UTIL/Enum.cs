using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EspacoTP.UTIL
{
    public static class Enum
    {
        public enum TipoConexaoBanco
        {
            HomologacaoConexaoRemota = 0,
            ProducaoConexaoRemota = 1,
            HomologacaoConexaoLocal = 2,
            ProducaoConexaoLocal = 3
        }
    }
}
