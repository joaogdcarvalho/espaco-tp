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
    class AlunosBLL
    {
        public static DataTable Select(out string pstrMensagem, out bool pbooRetorno, AlunosTO pAluno)
        {
            DataTable dtTabela = AlunosDAL.Select(out pstrMensagem, out pbooRetorno, pAluno);

            return dtTabela;
        }

        public static AlunosTO DetalharAluno(out string pstrMensagem, out bool pbooRetorno, int pnumIdAluno)
        {
            AlunosTO alu = AlunosDAL.DetalharAluno(out pstrMensagem, out pbooRetorno, pnumIdAluno);

            return alu;
        }

        public static int ContarAlunos(out string pstrMensagem, out bool pbooRetorno)
        {
            int intResult = AlunosDAL.ContarAlunos(out pstrMensagem, out pbooRetorno);

            return intResult;
        }

        public static bool TratarEfetivacao(out string pstrMensagem, out bool pbooRetorno, bool pbooInclusao, AlunosTO pAluno)
        {
            bool booEfetivacao = false;
            int intQuantidadeRg = 0;

            if (pbooInclusao)
            {
                intQuantidadeRg = AlunosDAL.Insert(out pstrMensagem, out pbooRetorno, pAluno);
            }
            else
            {
                intQuantidadeRg = AlunosDAL.Update(out pstrMensagem, out pbooRetorno, pAluno);
            }

            if (intQuantidadeRg > 0)
            {
                booEfetivacao = true;
            }

            return booEfetivacao;
        }
    }
}