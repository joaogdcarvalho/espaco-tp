using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EspacoTP.MODEL;
using EspacoTP.DAL;
using EspacoTP.UTIL;
using System.Data;

namespace EspacoTP.BLL
{
    class InstrutoresBLL
    {
        public static DataTable Buscar(out string pstrMensagem, out bool pbooRetorno)
        {
            DataTable dtTabela = InstrutoresDAL.Buscar(out pstrMensagem, out pbooRetorno);

            return dtTabela;
        }

        public static bool TratarEfetivacao(out string pstrMensagem, out bool pbooRetorno, bool pbooInclusao, InstrutoresTO pInstrutor)
        {
            bool booEfetivacao = false;
            int intQuantidadeReg = 0;

            if (pbooInclusao)
            {
                intQuantidadeReg = InstrutoresDAL.Incluir(out pstrMensagem, out pbooRetorno, pInstrutor);
            }
            else
            {
                intQuantidadeReg = InstrutoresDAL.Alterar(out pstrMensagem, out pbooRetorno, pInstrutor);
            }

            if (intQuantidadeReg > 0)
            {
                booEfetivacao = true;
            }

            return booEfetivacao;
        }

        public static int ContarInstrutores(out string pstrMensagem, out bool pbooRetorno)
        {
            int intResult = InstrutoresDAL.ContarInstrutores(out pstrMensagem, out pbooRetorno);

            return intResult;
        }
    }
}